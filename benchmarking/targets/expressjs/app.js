const express = require('express');
const app = express();

app.get('/benchmark/simple-http', (_req, res) => {
  let message = `Hitting ExpressJS : ${new Date().toUTCString()}`
  res.status(200).send(message);
})

app.listen(3000, () => console.log('Example app listening on port 3000!'));