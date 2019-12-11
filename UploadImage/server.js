const express = require('express');
const multer = require('multer');

var storageConfig = multer.diskStorage({
    destination: function (req, file, cb) {
      cb(null, __dirname + '/uploads/images')
    },
    filename: function (req, file, cb) {
      cb(null, file.originalname)
    }
  })

const upload = multer({storage:storageConfig});

const app = express();
const PORT = 3000;

app.use(express.static('public'));

app.post('/upload', upload.single('photo'), (req, res) => {
    if(req.file) {        
        res.json(req.file);
        console.log(req.file);
    }
    else throw 'error';
});

app.listen(PORT, () => {
    console.log('Listening at ' + PORT );
});