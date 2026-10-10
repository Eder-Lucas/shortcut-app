import express from 'express'
import database from 'better-sqlite3'
import cors from 'cors'
import { spawn } from 'node:child_process'
import path from 'node:path'
import { fileURLToPath } from 'node:url'

const dirname = path.dirname(fileURLToPath(import.meta.url))

const app = express()
const PORT = 4040

app.use(express.json())
app.use(cors({
    origin: "http://localhost:4040"
}))

let processoAberto = false
let processo = null

const db = new database(path.resolve(dirname, './database.db'))

async function startDataBase() {
    
    db.exec(`
        CREATE TABLE IF NOT EXISTS config (
            id INTEGER PRIMARY KEY,
            iniciar BOOLEAN NOT NULL DEFAULT 1
        )
    `)

    db.prepare(`
        INSERT OR IGNORE INTO config (id, iniciar) VALUES (?, ?)
    `).run(1, 1)
}

async function getConfigStart() {
    const configIniciar = db.prepare(`
        SELECT iniciar FROM config WHERE id == 1
    `).get()

    return configIniciar.iniciar === 1
} 

app.get('/', (req, res) => {
    res.json({
        mensagem: "teste"
    })
})

app.post('/parar', (req, res) => {
    if (processo != null) {
        processo.kill()

        res.json({
            mensagem: "Processo encerrado"
        })
        console.log(processo)

        processo = null
        processoAberto = false
    }
    else {
        res.json({
            mensagem: "Não há processo aberto"
        })
    }
})

function iniciarProcesso() {
    const caminho = path.resolve(dirname, '../script/atalho.exe')
    console.log(processo)

    if (processoAberto) {
        console.log(processoAberto)

        return {
            mensagem: "o processo já está aberto. PID: " + processo.pid
        }
    }
    else {
        processo = spawn(caminho)

        processo.on('error', (err) => {
            console.error('Falha ao executar o arquivo:', err.message)
        })

        processoAberto = true

        console.log(`pid: ${processo.pid}`)

        return {
            mensagem: `processo rodando: ${processo.pid}`
        }        
    }

    console.log(`processo: ${processoAberto}`)
}

app.post('/iniciar', (req, res) => {
    const resposta = iniciarProcesso()
    res.json(resposta)
})

app.listen(PORT, '0.0.0.0', async () => {
    await startDataBase()

    const start = await getConfigStart()

    console.log(`Servidor rodando: ${PORT}`)

    if (start) {
        iniciarProcesso()
        console.log("Iniciando processo automaticamente")
    }
    
    
    /*const caminho = path.resolve(dirname, './')
    console.log(caminho)*/
})