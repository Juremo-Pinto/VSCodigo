const http = require('http');
const fs = require('fs');
const path = require('path')

let numeroSecreto = Math.floor(Math.random() * 100) + 1;
let tentativas = 5;

const server = http.createServer((req, res) => {
    const urlParams = new URL(req.url, 'http://localhost:3001');
    const endpoint = urlParams.pathname;

    if (endpoint === '/') {
        const filePath = path.join(__dirname, 'game.html');

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {

                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(content);
            }

        })

    } else if (endpoint === "/jogar") {
        const chute = Number(urlParams.searchParams.get("chute"));

        tentativas--;

        if (chute === numeroSecreto) {

            res.writeHead(302, { Location: "/goodjob" });

        } else if (tentativas >= 0) {

            if (chute > numeroSecreto) {
                document.getElementById("dica").innerHTML = ;

            }

            res.writeHead(302, { Location: "/" });

        } else {

            res.writeHead(302, { Location: "/badjob" });

        }

        res.end();

    } else if (endpoint === '/goodjob') {
        const filePath = path.join(__dirname, 'youwin.html');
        numeroSecreto = Math.floor(Math.random() * 100) + 1;
        tentativas = 5;

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {

                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(content);
            }
        })

    } else if (endpoint === '/badjob') {
        const filePath = path.join(__dirname, 'youloose.html');

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {

                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(content);
            }

        })

    };
})
