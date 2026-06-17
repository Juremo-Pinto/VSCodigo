const http = require('http');
const fs = require('fs');
const path = require('path');

const server = http.createServer((req, res) => {

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

    } else if (req.url === '/hello') {
        const filePath = path.join(__dirname, 'index1.html');

        fs.readFile(filePath, (err, content) => {

            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/plain' });
                res.end('Erro no servidor');

            } else {
                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(content);
            }

        });

    } else if (['/oi', '/ola', '/hi'].includes(req.url)) {
        res.writeHead(301, { 'Location': '/hello' });
        res.end();

    } else {
        const filePath = path.join(__dirname, 'index404.html');

        fs.readFile(filePath, (err, content) => {
            res.writeHead(404, {'Content-Type': 'text/html'});
            res.end(content);
        });
    }
});

const port = 3001;
server.listen(port, () => {
    console.log('Servidor rodano em http://localhost:3001/');

});