const http = require('http');
const fs = require('fs');
const path = require('path');

const server = http.createServer((req, res) => {

    let admin = false;

    if (req.url === '/') {
        const filePath = path.join(__dirname, 'index.html');

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {
                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(content);
            }

        });
    } else if (req.url === '/login' && req.method === "POST") {

        let body = "";

        req.on("data", chunk => {
            body += chunk.toString();
        });

        req.on("end", () => {
            const params = new URLSearchParams(body);
            const usuario = params.get("usuario");
            const senha = params.get("senha");

            if (usuario === "" && senha === "") {

                res.writeHead(302, { Location: "/dashboard" });
                return res.end();

            } else {

                const filePath = path.join(__dirname, 'login.html');

                fs.readFile(filePath, (err, content) => {

                    if (err) {
                        res.writeHead(500, { 'Content-Type': 'text/plain' });
                        res.end('Erro no servidor');

                    } else {
                        res.writeHead(200, { 'Content-Type': 'text/html' });
                        res.end(content);
                    }

                });
            }
        });

    } else if (req.url === '/dashboard') {
        const filePath = path.join(__dirname, 'dashboard.html');

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {
                res.writeHead(401, { 'Content-Type': 'text/html' });
                res.end(content);
            }

        });
    } else if (req.url === '/admin' && admin == false) {
        const filePath = path.join(__dirname, 'nadmin.html');

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {
                res.writeHead(403, { 'Content-Type': 'text/html' });
                res.end(content);
            }

        });
    } else if (req.url === '/admin' && admin == true) {
        const filePath = path.join(__dirname, 'admin.html');

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {
                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(content);
            }

        });
    } else {
            const filePath = path.join(__dirname, 'index404.html');
    
            fs.readFile(filePath, (err, content) => {
                res.writeHead(404, { 'Content-Type': 'text/html' });
                res.end(content);
            });
        }
})
const port = 3001;
server.listen(port, () => {
    console.log('Servidor rodano em http://localhost:3001/');

});