// File Upload Component
// options:
// - DropFilesPrompt (string)
// - ChooseFilePrompt (string)
// - Accept (string)
// - Multiple (boolean)
// - UseSorting (boolean)
// - MaximumUploadFiles (number)
// - MaximumUploadFileSize (number)
// - FileMaximumUploadSizeReachedMessage (string)
// - FileWrongTypeMessage (string)
// - FileAmountMessage (string)
// - FileSelectMessage (string)
// - UploadOptions (array of sting) e.g ['DOCX', 'DOC', ...]
// - WebApiPath (string)
// - Method (callback)
// - showAlert (function (string) => void)
// - hideAlert (function () => void)
// - showLoader (function () => void)
// - progress (function () => void)

/**
 * Global variable to keep track of the index for file drop handlers.
 */
var handlerFileDropAssignIndex = 0;

if (document.getElementById('idFile')) {
	var idFileBlock = parseInt(document.getElementById('idFile').innerHTML);
}

/**
 * Initialize the file drop functionality.
 * @param {Object} options - Options for configuring the file drop behavior.
 * @returns {Object} An object providing access to various functions and data related to file drop.
 */
var filedrop = function (options) {
	/**
     * Generates a random integer.
     * @returns {number} A random integer.
     */
	this.getRandomIntInclusive = function () {
		idFileBlock = idFileBlock + 1;
		return idFileBlock - 1;
	};

	var randomId = getRandomIntInclusive();

	var acceptExts = options.Accept.split(/s*,s*/).map(function (ext) {
		return ext.substring(1).toUpperCase();
	});

	var droppedFiles = [];

	this.getFileExtension = function (file) {
		var pos = file.name.lastIndexOf('.');
		return pos !== -1 ? file.name.substring(pos + 1).toUpperCase() : null;
	};

	this.nextFileId = function () {
		var id = 1;
		var found;
		do {
			found = false;
			for (let i = 0; i < droppedFiles.length; i++) {
				if (droppedFiles[i].id === 'link_' + id) {
					id += 1;
					found = true;
					break;
				}

				if (droppedFiles[i].id === id) {
					id += 1;
					found = true;
					break;
				}
			}
		} while (found);
		return id;
	};

	this.preventFileDrop = function (evt) {
		evt = evt || event;
		evt.preventDefault();
		evt.stopPropagation();
	};

	this.removeFileBlock = function (id) {
		var pos;
		for (pos = 0; pos < droppedFiles.length; pos++) {
			if (droppedFiles[pos].id === id) {
				document.getElementById('fileupload-' + id).remove();
				droppedFiles.splice(pos, 1);
				if (droppedFiles.length === 0) { // the last file was removed

					filedrop = document.querySelector('.filedrop');
					if (filedrop.classList.contains('hide-drop-files-hint')) {
						filedrop.classList.remove('hide-drop-files-hint');
					}
					//document.querySelector('#filedrop-' + randomId).querySelector('.chooseFilesLabel').classList.remove('hidden');
				};
				break;
			}
		}
	};

	this.moveUpFileBlock = function (id) {
		var pos;
		for (pos = 0; pos < droppedFiles.length; pos++) {
			if (droppedFiles[pos].id === id) {
				break;
			}
		}
		if (pos < droppedFiles.length && pos !== 0) {
			var prevId = droppedFiles[pos - 1].id;
			var flTemp = droppedFiles[pos - 1];
			droppedFiles[pos - 1] = droppedFiles[pos];
			droppedFiles[pos] = flTemp;

			var block = document.querySelector('#filedrop-' + randomId + ' > div > #fileupload-' + id);
			var prevBlock = document.querySelector('#filedrop-' + randomId + ' > div > #fileupload-' + prevId)
			block.parentNode.insertBefore(block, prevBlock);
		}
	};

	this.moveDownFileBlock = function (id) {
		var pos;
		for (pos = 0; pos < droppedFiles.length; pos++) {
			if (droppedFiles[pos].id === id) {
				break;
			}
		}
		if (pos < droppedFiles.length && pos !== (droppedFiles.length - 1)) {
			var nextId = droppedFiles[pos + 1].id;
			var flTemp = droppedFiles[pos + 1];
			droppedFiles[pos + 1] = droppedFiles[pos];
			droppedFiles[pos] = flTemp;

			var block = document.querySelector('#filedrop-' + randomId + '> div > #fileupload-' + id);
			var nextBlock = document.querySelector('#filedrop-' + randomId + ' > div > #fileupload-' + nextId)
			block.parentNode.insertBefore(nextBlock, block);
		}
	};

	this.el = function (htmlString) {
		var div = document.createElement('div');
		div.innerHTML = htmlString.trim();

		// Change this to div.childNodes to support multiple top-level nodes
		return div.firstChild;
	};

	this.appendFileBlock = function (file, idUploadBlock) {
		var id = nextFileId();
		var name = file.name;
		var fileMoveUpLink = null;
		var fileMoveDownLink = null;

		if (options.UseSorting) {
			fileMoveUpLink = el('<a><i><svg class="fa icon icon-arrow-up frame0" viewBox="0 0 30 32"><path d="M28.768 17.339q0 0.911-0.661 1.607l-1.339 1.339q-0.679 0.679-1.625 0.679-0.964 0-1.607-0.679l-5.25-5.232v12.571q0 0.929-0.67 1.509t-1.616 0.58h-2.286q-0.946 0-1.616-0.58t-0.67-1.509v-12.571l-5.25 5.232q-0.643 0.679-1.607 0.679t-1.607-0.679l-1.339-1.339q-0.679-0.679-0.679-1.607 0-0.946 0.679-1.625l11.625-11.625q0.625-0.661 1.607-0.661 0.964 0 1.625 0.661l11.625 11.625q0.661 0.696 0.661 1.625z"></path></svg></i></a>');
			fileMoveDownLink = el('<a><i><svg class="fa icon icon-arrow-down frame0" viewBox="0 0 30 32"><path d="M28.768 14.857q0 0.946-0.661 1.607l-11.625 11.643q-0.696 0.661-1.625 0.661-0.946 0-1.607-0.661l-11.625-11.643q-0.679-0.643-0.679-1.607 0-0.946 0.679-1.625l1.321-1.339q0.696-0.661 1.625-0.661 0.946 0 1.607 0.661l5.25 5.25v-12.571q0-0.929 0.679-1.607t1.607-0.679h2.286q0.929 0 1.607 0.679t0.679 1.607v12.571l5.25-5.25q0.661-0.661 1.607-0.661 0.929 0 1.625 0.661l1.339 1.339q0.661 0.696 0.661 1.625z"></path></svg></i></a>');

			fileMoveUpLink.querySelector('i').addEventListener('click', function () {
				moveUpFileBlock(id);
			});
			fileMoveDownLink.querySelector('i').addEventListener('click', function () {
				moveDownFileBlock(id);
			});
		}
		var fileRemoveLink = el('<a><i><svg class="fa icon icon-close frame0" viewBox="0 0 25 32"><path d="M23.179 23.607q0 0.714-0.5 1.214l-2.429 2.429q-0.5 0.5-1.214 0.5t-1.214-0.5l-5.25-5.25-5.25 5.25q-0.5 0.5-1.214 0.5t-1.214-0.5l-2.429-2.429q-0.5-0.5-0.5-1.214t0.5-1.214l5.25-5.25-5.25-5.25q-0.5-0.5-0.5-1.214t0.5-1.214l2.429-2.429q0.5-0.5 1.214-0.5t1.214 0.5l5.25 5.25 5.25-5.25q0.5-0.5 1.214-0.5t1.214 0.5l2.429 2.429q0.5 0.5 0.5 1.214t-0.5 1.214l-5.25 5.25 5.25 5.25q0.5 0.5 0.5 1.214z"></path></svg></i></a>');
		fileRemoveLink.querySelector('i').addEventListener('click', function () {
			removeFileBlock(id);
		});
		var spanFileName = el('<span class="filename"><label style="display:inline">' + name + '</label></span>');
		if (fileMoveUpLink !== null && fileMoveDownLink !== null) {
			spanFileName.appendChild(fileMoveUpLink);
			spanFileName.appendChild(fileMoveDownLink);
		}
		spanFileName.appendChild(fileRemoveLink);

		var fileBlock = el('<div id="fileupload-' + id + '" class="fileupload"></div>');
		fileBlock.addEventListener('dragover', preventFileDrop);
		fileBlock.addEventListener('drop', preventFileDrop);
		fileBlock.appendChild(spanFileName);

		var filedrop = null;
		if (!isNullOrEmpty(idUploadBlock)) {
			filedrop = document.getElementById(idUploadBlock).closest('.filedrop-container').querySelector('.filedrop');
			if (!filedrop.classList.contains('hide-drop-files-hint')) {
				filedrop.classList.add('hide-drop-files-hint');
			}
		}
		else {
			filedrop = document.querySelector('.filedrop');
			if (!filedrop.classList.contains('hide-drop-files-hint')) {
				filedrop.classList.add('hide-drop-files-hint');
			}
		}
		filedrop.querySelector('.fileupload-list').appendChild(fileBlock);

		droppedFiles.push({
			id,
			file,
			name,
			idUploadBlock
		});
	};

	this.prepareFormData = function (min = 1, max = undefined) {
		if (max === undefined)
			max = options.MaximumUploadFiles;

		if (droppedFiles.length) {
			if (droppedFiles.length < min || droppedFiles.length > max) {
				showAlert(options.FileAmountMessage);
				return null;
			}

			var data = new FormData();
			var dotPos, ext;
			var f;
			var sizeSum = 0;
			for (var i = 0; i < droppedFiles.length; i++) {
				f = droppedFiles[i];
				dotPos = f.name.lastIndexOf('.');
				ext = dotPos >= 0 ? f.name.substring(dotPos + 1).toUpperCase() : null;
				if (!f.url && (options.AcceptAllFormats || (ext !== null && options.UploadOptions.indexOf(ext) !== -1))) {
					data.append(f.id, f.file, f.name);
				} else if (f.url) {
					data.append(f.id, f.url);
				} else {
					showAlert(options.FileWrongTypeMessage + ext);
					return null;
				}

				if (options.MaximumUploadFileSize > 0) {
					var maxFileSize = options.MaximumUploadFileSize;
					if (!f.url && f.file.size > maxFileSize) {
						showAlert(options.FileMaximumUploadSizeReachedMessage);
						return null;
					}
					else if (!f.url) {
						sizeSum += f.file.size;
						if (sizeSum > maxFileSize) {
							showAlert(options.FileMaximumUploadSizeReachedMessage);
							return null;
						}
					}
				}
			}

			data.append("DocumentPassword", document.getElementById("documentPassword").value);

			let isLandscape = document.querySelector('#dcIsLandscape');
			if (isLandscape !== null)
				data.append("dc_isLandscape", isLandscape.value == 'on' ? "true" : "false");
			else
				data.append("dc_isLandscape", "false");

			return data;
		} else {
			showAlert(options.FileSelectMessage);
			return null;
		}
	};

	this.uploadFileSelected = function (event) {
		if (options.onFilesChanged) {
			options.onFilesChanged(event)
			return false;
		}

		var bError = false;
		if (event.target.files && event.target.files.length) {
			var fileCount = o.AppName === "comparison" && droppedFiles.find(x => x.idUploadBlock == event.target.name) == undefined
				? event.target.files.length
				: event.target.files.length + droppedFiles.length;

			if (fileCount <= options.MaximumUploadFiles) {
				var ext;
				hideAlert();
				for (var i = 0; i < event.target.files.length; i++) {
					ext = getFileExtension(event.target.files[i]);
					if (options.AcceptAllFormats || (ext !== null && acceptExts.indexOf(ext) !== -1)) {
						if (event.target.files[i].size == 0) {
							showAlert(options.FileEmptyMessage + ' "' + event.target.files[i].name + '"');
						}
						else {
							appendFileBlock(event.target.files[i], event.target.id);
						}
					} else {
						bError = true;
						if (ext !== null)
							ext = ext.toUpperCase();
						showAlert(options.FileWrongTypeMessage + ext);
					}
				}
			} else {
				bError = true;
				showAlert(options.FileAmountMessage);
				window.setTimeout(function () {
					hideAlert();
				}, 5000);
			}
		}

		// clear the file input field
		document.querySelector('#UploadFileInput-' + randomId).value = '';
		return !bError;
	};

	this.handleFileInputDrop = function (fileDropNum) {
		const fileDropId = 'filedrop-' + fileDropNum;
		if (!isNullOrEmpty(document.getElementById(fileDropId))) {
			const fileInputId = 'input#UploadFileInput-' + fileDropNum;

			document.getElementById(fileDropId).addEventListener('click', function (e) {
				if (e.target.classList.contains('fileupload-list')) {
					document.querySelector(fileInputId).click();
				}
				if (e.target.parentNode.classList.contains('filedrop-container')) {
					document.querySelector(fileInputId).click();
				}
			});

			document.getElementById(fileDropId).addEventListener('dragover', function (e) {
				e.preventDefault();
				e.stopPropagation();
			});

			document.getElementById(fileDropId).addEventListener('dragenter', function (e) {
				e.preventDefault();
				e.stopPropagation();
			});

			document.getElementById(fileDropId).addEventListener('drop', function (e) {
				if (e.dataTransfer && e.dataTransfer.files.length) {
					e.preventDefault();
					e.stopPropagation();

					const { files } = e.dataTransfer;
					uploadFileSelected({
						target: {
							id: 'UploadFileInput-' + fileDropNum,
							name: 'UploadFileInput-' + fileDropNum,
							files,
						}
					});
				}
			});
		}
	};

	// adding event handlers
	if (handlerFileDropAssignIndex == 0) {
		var queryObj = document.querySelector('input#UploadFileInput-' + randomId);
		if (!isNullOrEmpty(queryObj))
			queryObj.addEventListener('change', uploadFileSelected);
		if (o.AppName == "comparison") {
			queryObj = document.querySelector('input#UploadFileInput-' + (randomId + 1));
			if (!isNullOrEmpty(queryObj))
				queryObj.addEventListener('change', uploadFileSelected);
		}

		handleFileInputDrop(randomId);
		var fileDropId = 'filedrop-' + (randomId + 1);
		if (!isNullOrEmpty(document.getElementById(fileDropId))) {
			handleFileInputDrop(randomId + 1);
		};
		handlerFileDropAssignIndex += 1;
	}

	// return object with access fields
	return {
		 /**
         * Gets the JavaScript options used for configuring the file drop behavior.
         * @returns {Object} JavaScript options.
         */
		get jsOptions() {
			return options;
		},
		 /**
         * Gets a function to generate a random file ID.
         * @returns {Function} Function to generate a random file ID.
         */
		get randomFileId() {
			return getRandomIntInclusive;
		},
		/**
         * Gets the array of dropped files.
         * @returns {Array} Array of dropped files.
         */
		get droppedFiles() {
			return droppedFiles;
		},
		 /**
         * Gets a function to prepare form data for file upload.
         * @returns {Function} Function to prepare form data.
         */
		get prepareFormData() {
			return prepareFormData;
		},
		 /**
         * Gets a function to append a file block to the file upload list.
         * @returns {Function} Function to append a file block.
         */
		get appendFile() {
			return appendFileBlock;
		},
		/**
         * Gets a function to handle when files are selected for upload.
         * @returns {Function} Function to handle file selection.
         */
		get uploadFileSelected() {
			return uploadFileSelected;
		},
		/**
         * Gets a function to generate the next file ID.
         * @returns {Function} Function to generate the next file ID.
         */
		get nextFileId() {
			return nextFileId;
		},
		/**
         * Sets a function to append a file block.
         * @param {Function} func - Function to append a file block.
         */
		set setAppendFileBlock(func) {
			appendFileBlock = func;
		},
		/**
         * Resets the file drop functionality by clearing dropped files and removing file blocks from the UI.
         */
		reset: function reset() {
			droppedFiles = [];
			document.querySelector('#filedrop-' + randomId).querySelector('div[id^=fileupload-]').remove();
		}
	};
}(o);