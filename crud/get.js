const request = require("request");

request({
  "rejectUnauthorized": false,
  "url": "https://localhost:44365/api/medico/",
  "method": "GET"

}, function (err, response, body) {
  console.log(body);
});
