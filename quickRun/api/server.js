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

app.get('/', (req, res) => {
    res.json({
        mensagem: "teste"
    })
})

app.post('/iniciar', (req, res) => {
    const caminho = path.resolve(dirname, '../script/atalho.exe')
    const processo = spawn(caminho)

    processo.on('error', (err) => {
        console.error('Falha ao executar o arquivo:', err.message)
    })

    console.log(`pid: ${processo.pid}`)

    res.json({
        mensagem: `processo rodando: ${processo.pid}`
    })
})

app.listen(PORT, '127.0.0.1', () => {
    console.log(`Servidor rodando: ${PORT}`)
})