const express = require('express');
const app = express();
app.use(express.json());

app.get('/home', (req, res) => res.send('<h1>Home</h>'));
app.post('/login', (req, res) => res.json({ msg: 'Lol', dados: req.body }));

app.listen(3001, () => console.log('Rodando em 3001'));