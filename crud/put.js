const request = require("request");
request.put({
  "rejectUnauthorized": false,
  "url": "https://localhost:44365/api/medico/1",
  json: {
    crm: 1,
    nome: "hjhhfgsCA"
  }
},
  function (err, response, body) {
    console.log(body);
  });