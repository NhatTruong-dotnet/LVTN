export function uploadFileToDrive(file, onSuccess, onError) {
    var reader = new FileReader() //this for convert to Base64
    reader.readAsDataURL(file) //start conversion...

    reader.onload = function (e) {
        //.. once finished..
        var rawLog = reader.result.split(',')[1] //extract only thee file data part
        var dataSend = {
            dataReq: { data: rawLog, name: file.name, type: file.type },
            fname: 'uploadFilesToGoogleDrive',
        } //preapre info to send to API
        fetch(
            'https://script.google.com/macros/s/AKfycbwXhX4N82ic3vhrVOK493pjOfR9-pISPf7jsSmpiBcf_IHuQCc/exec', //your AppsScript URL
            { method: 'POST', body: JSON.stringify(dataSend) }
        ) //send to Api
            .then(res => res.json())
            .then(onSuccess)
            .catch(onError) // Or Error in console
    }
}
