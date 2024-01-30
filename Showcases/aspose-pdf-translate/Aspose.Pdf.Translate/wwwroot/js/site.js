function fromChange() {
    var from = document.querySelector('select[name=from]').value;
    document.querySelector("#to option").style.display = 'block';
    document.querySelector("#to option[value='" + from + "']").style.display = 'none';

    if (from != 'en') {
        document.querySelector('select[name=to]').value = 'en';
    }
    else {
        document.querySelector('select[name=to]').value = 'fr';
    }
}

function requestTranslate() {

    ShowLoadingWaiter();
    let items = getFilesFromUrls(fileDrop.droppedFiles, googleDriveApi.accessToken);

    Promise.all(items)
        .then((loadedData) => {
            console.log(loadedData);
            loadedData.forEach((item) => {
                if (!IsNullOrEmpty(item.file)) {
                    var i = fileDrop.droppedFiles.findIndex((element, index) => {
                        return (element.id == item.id ? true : false);
                    });
                    if (i >= 0) {
                        fileDrop.droppedFiles[i].url = undefined;
                        fileDrop.droppedFiles[i].file = item.file;
                    }
                }
            });
            HideLoadingWaiter();

            let data = fileDrop.prepareFormData(1, o.MaximumUploadFiles);
            if (data === null)
                return;

            var from = document.querySelector('select[name=from]').value;
            var to = document.querySelector('select[name=to]').value;
            var translateAll = true;

            var url1 = o.WebApiPath + 'translate?inputType=' +
                getInputType('translate') +
                '&from=' + from +
                '&to=' + to +
                '&translateAll=' + translateAll;
            requestQueue(url1, data);
        });
}

function getLangCode(language) {
    switch (language.toLowerCase()) {
        case "english":
            return "en";
            break;
        case "german":
            return "de";
            break;
        case "french":
            return "fr";
            break;
        case "italian":
            return "it";
            break;
        case "spanish":
            return "es";
            break;
        case "arabic":
            return "ar";
            break;
        case "russian":
            return "ru";
            break;
        case "chinese":
            return "zh";
            break;
        case "portuguese":
            return "pt";
            break;
        case "polish":
            return "pl";
            break;
        case "azerbaijani":
            return "az";
            break;
        case "latvian":
            return "lv";
            break;
        case "lithuanian":
            return "lt";
            break;
    }
}

var o = {
    "MaximumUploadFileSize": 31457280,
    "FileMaximumUploadSizeReachedMessage": "Files upload size must be equal or less than 31457280 bytes. To remove limitation of direct upload you can Enter Url from google drive, dropbox or from public web.", "AppURL": "https://products.aspose.app/pdf/translate", "AppName": "translate", "OriginalAppName": "Translate", "AppRoute": "/pdf/translate", "WebApiPath": "https://localhost:5002/pdf/webapi/", "StatusStorage": "redis", "UIBasePath": "", "ViewerPathWF": "/pdf/viewer/", "ViewerPath": "/pdf/viewer/ViewPdf?", "EditorPathWF": "/pdf/editor/", "EditorPath": "/pdf/editor/EditPdf?", "FileSelectMessage": "Please select a file to upload", "ShowViewerButton": true, "MaximumUploadFiles": 10, "FileAmountMessage": "Please select less than ten files", "FileEmptyMessage": "Selected file is empty", "UploadAndRedirect": false, "UseSorting": true, "FileWrongTypeMessage": "You are trying to upload document(s) of unsupported type:", "CurrentAppLang": "en", "AppRouteTemplate": "/pdf{0}/translate", "AllSupportedLang": [{ "Id": "id", "Description": "Bahasa Indonesia", "ChangeToLanguage": "Indonézre váltani?", "UrlId": "/id" }, { "Id": "ms", "Description": "Bahasa Melayu", "ChangeToLanguage": "Tukar ke melayu?", "UrlId": "/ms" }, { "Id": "ca", "Description": "Català", "ChangeToLanguage": "Voleu canviar al català?", "UrlId": "/ca" }, { "Id": "cs", "Description": "Čeština", "ChangeToLanguage": "Změnit na češtinu?", "UrlId": "/cs" }, { "Id": "da", "Description": "Dansk", "ChangeToLanguage": "Skift til dahish?", "UrlId": "/da" }, { "Id": "de", "Description": "Deutsch", "ChangeToLanguage": "Auf Deutsch wechseln?", "UrlId": "/de" }, { "Id": "nl", "Description": "Dutch", "ChangeToLanguage": "Veranderen naar nederlands?", "UrlId": "/nl" }, { "Id": "en", "Description": "English", "ChangeToLanguage": "Change to English?", "UrlId": "" }, { "Id": "es", "Description": "Español", "ChangeToLanguage": "¿Cambiar al español?", "UrlId": "/es" }, { "Id": "fr", "Description": "Français", "ChangeToLanguage": "Changer en français ?", "UrlId": "/fr" }, { "Id": "it", "Description": "Italiano", "ChangeToLanguage": "Cambia in italiano?", "UrlId": "/it" }, { "Id": "lt", "Description": "Lietuvis", "ChangeToLanguage": "Keisti į lietuvišką?", "UrlId": "/lt" }, { "Id": "hu", "Description": "Magyar", "ChangeToLanguage": "Magyarra váltani?", "UrlId": "/hu" }, { "Id": "fil", "Description": "Pilipino", "ChangeToLanguage": "Palitan ng filipino?", "UrlId": "/fil" }, { "Id": "pl", "Description": "Polski", "ChangeToLanguage": "Zmienić na polski?", "UrlId": "/pl" }, { "Id": "pt", "Description": "Português", "ChangeToLanguage": "Mudar para português?", "UrlId": "/pt" }, { "Id": "ro", "Description": "Română", "ChangeToLanguage": "Treceți la română?", "UrlId": "/ro" }, { "Id": "sv", "Description": "Svenska", "ChangeToLanguage": "Byt till svenska?", "UrlId": "/sv" }, { "Id": "vi", "Description": "Tiếng Việt", "ChangeToLanguage": "Đổi sang tiếng Việt?", "UrlId": "/vi" }, { "Id": "tr", "Description": "Türkçe", "ChangeToLanguage": "Türkçe değiştir?", "UrlId": "/tr" }, { "Id": "el", "Description": "Ελληνικά", "ChangeToLanguage": "Αλλαγή σε ελληνικά;", "UrlId": "/el" }, { "Id": "bg", "Description": "Български", "ChangeToLanguage": "Да се промени на български?", "UrlId": "/bg" }, { "Id": "kk", "Description": "Қазақ", "ChangeToLanguage": "Қазақ тіліне ауысу керек пе?", "UrlId": "/kk" }, { "Id": "ru", "Description": "Русский", "ChangeToLanguage": "Изменить на Русский?", "UrlId": "/ru" }, { "Id": "uk", "Description": "Українська", "ChangeToLanguage": "Змінити на українську?", "UrlId": "/uk" }, { "Id": "he", "Description": "עִברִית", "ChangeToLanguage": "לעבור לעברית?", "UrlId": "/he" }, { "Id": "ar", "Description": "العربية", "ChangeToLanguage": "تغيير إلى العربية؟", "UrlId": "/ar" }, { "Id": "fa", "Description": "فارسی", "ChangeToLanguage": "تغییر به فارسی؟", "UrlId": "/fa" }, { "Id": "hi", "Description": "हिंदी", "ChangeToLanguage": "हिंदी में बदलें?", "UrlId": "/hi" }, { "Id": "th", "Description": "ภาษาไทย", "ChangeToLanguage": "เปลี่ยนเป็นภาษาไทย?", "UrlId": "/th" }, { "Id": "ko", "Description": "한국어", "ChangeToLanguage": "한국어로 변경 하시겠습니까?", "UrlId": "/ko" }, { "Id": "zh-hant", "Description": "中國傳統的", "ChangeToLanguage": "換成中文？", "UrlId": "/zh-hant" }, { "Id": "zh", "Description": "中文", "ChangeToLanguage": "换成中文？", "UrlId": "/zh" }, { "Id": "ja", "Description": "日本語", "ChangeToLanguage": "日本語に変更しますか？", "UrlId": "/ja" }], "FileProcessingErrorCodes": { "10001": "No search results", "10002": "Wrong regular expression" }, "UploadOptions": ["PDF"], "AcceptAllFormats": false, "Multiple": true, "DropFilesPrompt": "Drop or upload your files*", "Accept": ".pdf"
};

var segments = o.AppRouteTemplate.split('/');
var lang = segments[segments.length - 1].split('-');
document.getElementById('from').onchange = fromChange;
document.querySelector("#to option[value='en']").style.display = 'none';
if (lang.length == 2 && lang[0].toLowerCase() != 'translate') {
    document.querySelector('select[name=from]').value = getLangCode(lang[0]);
    document.querySelector('select[name=to]').value = getLangCode(lang[1]);
}

function extend(a, b) {
    for (var key in b)
        if (b.hasOwnProperty(key))
            a[key] = b[key];
    return a;
};

extend(o, {
    Method: requestTranslate,
    FileAmountMessage: 'Please select only one file',
    MaximumUploadFiles: 1,
    UseSorting: false
});