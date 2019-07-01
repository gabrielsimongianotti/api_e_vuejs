const request = require("request");

request({
  "rejectUnauthorized": false,
  "url": "https://localhost:44365/api/medico/1",
  "method": "delete"

}, function (err, response, body) {
  console.log(body);
});
