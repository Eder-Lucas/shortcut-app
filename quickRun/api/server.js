import express from 'express'
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

app.post('/iniciar', (req, res) => {
    const caminho = path.resolve(dirname, '../script/atalho.exe')
    console.log(processo)

    if (processoAberto) {
        res.json({
            mensagem: "o processo já está aberto. PID: " + processo.pid
        })
        console.log(processoAberto)
    }
    else {
        processo = spawn(caminho)

        processo.on('error', (err) => {
            console.error('Falha ao executar o arquivo:', err.message)
        })

        res.json({
            mensagem: `processo rodando: ${processo.pid}`
        })
        processoAberto = true

        console.log(`pid: ${processo.pid}`)
    }

    console.log(`processo: ${processoAberto}`)
})

app.listen(PORT, '0.0.0.0', () => {
    console.log(`Servidor rodando: ${PORT}`)
})