const request = require("request");
request.post({
  "rejectUnauthorized": false,
  "url": "https://localhost:44365/api/medico/",
  json: {
    nome: "hjhCA"
  }
},
  function (err, response, body) {
    console.log(body);
  });