const http = require('http');
const fs = require('fs');
const path = require('path')

let numeroSecreto = Math.floor(Math.random() * 100) + 1;
let tentativas = 0;

const server = http.createServer((req, res) => {
    const urlParams = new URL(req.url, 'http://localhost:3001');
    const endpoint = urlParams.pathname;
    let n = Math.floor(Math.random() * 100) + 1;
    console.log(n);

    if (endpoint === '/') {
        const filePath = path.join(__dirname, 'botão.html');

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {

                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(content);
            }

        })

    } else if (endpoint === '/goodjob') {
        const filePath = path.join(__dirname, 'youwin.html');

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {

                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(content);
            }
        })
    }

})

const port = 3001;
server.listen(port, () => {
    console.log('Servidor rodano em http://localhost:3001/');

});