/**
 * Sends a POST request to the specified URL with the provided data.
 * Handles loading, alerts, and button disabling/enabling during the request.
 * @param {string} url - The URL to send the request to.
 * @param {*} data - The data to send with the request.
 */
function requestQueue(url, data) {
	showLoader();
	hideAlert();
	disableButton();

	var request = new XMLHttpRequest();
	request.processData = false;
	request.cache = false;
	request.timeout = 6000000;

	request.onreadystatechange = function () {
		if (request.readyState === 4 && request.status == 200) {
			var resdata = JSON.parse(request.responseText);
			workSuccess(resdata, null, null, data);
		}
	}

	request.onerror = function (err) {
		activeButton();
		if (err.data !== undefined && err.data.Status !== undefined) {
			showAlert(err.data.Status);
		}
		else {
			if (err.status > 0)
				showAlert("Error " + err.status + ": " + err.responseText);
			else
				request.send(data);
		}
	}

	request.open("POST", url, true);
	request.withCredentials = true;
	request.send(data);
}

/**
 * Handles successful processing of work.
 * Depending on the status code received, it may display success, initiate further processing, or show an error.
 * @param {*} data - The response data from the server.
 * @param {string} textStatus - The status of the request.
 * @param {XMLHttpRequest} xhr - The XMLHttpRequest object.
 * @param {*} sendData - The data sent with the request.
 */
function workSuccess(data, textStatus, xhr, sendData) {
	if (data.statusCode === 200) {
		hideLoader();

		prepareDownloadButtons(data.sharedFiles, data.fileName)
		showSuccess();
	}
	else if (data.statusCode === 204) {
		showLoader();
		hideUploadForm();
		setTimeout(function () {
			workProcess(data);
		}, 150);
	}
	else {
		hideLoader();
		showUploadForm();
		activeButton();
		if (data.StatusCode !== 200) {
			showAlert(data.status);
		}
	}
}

/**
 * Initiates the processing of work with a delay.
 * @param {*} data - The data related to the work.
 */
function workProcess(data) {
	setTimeout(function () {
		executeStatusQuery(data);
	}, 5000);
}

/**
 * Executes a status query to check the progress of work.
 * @param {*} data - The data related to the work.
 */
function executeStatusQuery(data) {
	if (data === undefined) return;

	var request = new XMLHttpRequest();
	request.processData = false;
	request.cache = false;
	request.contentType = false;
	request.timeout = 120000;

	request.onreadystatechange = function () {
		if (request.readyState === 4 && request.status === 200) {
			let resdata = JSON.parse(request.responseText);
			workSuccess(resdata);
		}
	}

	request.onerror = function (err) {
		if (err.status != 0) {
			hideLoader();
			showUploadForm();
			activeButton();

			if (err.data !== undefined && err.data.Status !== undefined) {
				showAlert(err.data.Status);
			}
			else {
				if (err.status > 0)
					showAlert("Error " + err.status + ": " + err.responseText);
				else
					request.send(data);
			}
		}
		else {
			request.send(data);
		}
	}

	request.open("GET", o.WebApiPath + 'status/' + data.folderName, true);
	request.send(data);
}

/**
 * Prepares download buttons for each file provided.
 * @param {Array} files - Array of files to create download buttons for.
 * @param {string} fileName - The name of the file.
 */
function prepareDownloadButtons(files, fileName) {
	const downloadContainer = document.getElementById('download-container');

	for (var i = 0; i < files.length; i++) {
		const buttonsGroup = document.createElement("div");
		buttonsGroup.classList.add("cd-button-group");

		const downloadButton = createButton("cd-button cd-button--success", files[i].fileName, files[i].uploadFileName, "_target");
		buttonsGroup.appendChild(downloadButton);

		downloadContainer.appendChild(buttonsGroup);
	}
}

/**
 * Creates a button element with specified classes, text, href, and target.
 * @param {string} classes - The classes to apply to the button.
 * @param {string} text - The text content of the button.
 * @param {string} href - The URL the button will navigate to.
 * @param {string} target - The target attribute of the button.
 * @returns {HTMLAnchorElement} The created button element.
 */
function createButton(classes, text, href, target) {
	const button = document.createElement("a");

	button.className = classes;
	button.textContent = text;
	button.href = href;
	button.target = target;
	button.rel = "nofollow";

	return button;
}