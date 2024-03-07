// Function to create a form field based on the property's value
function createFormField(property, value) {
    var div = document.createElement('div');
    var label = document.createElement('label');
    var input = document.createElement('input');
    input.datakey = property;
    label.style.width = 100 + 'pt';

    // Set the label text to the property name
    var titleArray = property.match(/[A-Z][a-z]+/g);
    label.textContent = property.replace(/([a-zA-Z])(?=[A-Z])/g, '$1 ').toLowerCase();

    // Set the input type and value based on the data type
    if (typeof value === 'boolean') {
        input.type = 'checkbox';
        input.checked = value;
    } else if (typeof value === 'number' && value % 1 !== 0) {
        // Assuming all numbers are integers or doubles
        input.type = 'number';
        input.step = 'any'; // Allow for decimal values
    } else {
        input.type = 'text';
    }

    input.value = value;

    // Append the label and input to the div
    div.appendChild(label);
    div.appendChild(input);

    return div;
}

// Function to create a form from an object
function createFormFromObject(obj, parentElement) {
    for (var property in obj) {
        if (obj.hasOwnProperty(property)) {
            var value = obj[property];
            
            // If the value is an object or array, recurse
            if (typeof value === 'object' && value !== null) {
                if (Array.isArray(value)) {
                    value.forEach(function(item) {
                        createFormFromObject(item, parentElement);
                    });
                } else {
                    createFormFromObject(value, parentElement);
                }
            }else{
                var formField = createFormField(property, value);
                parentElement.appendChild(formField);    
            }
        }
    }
}

// Function to create an object instance from a class name
function createObjectFromClassName(className) {
    // Assuming the class is already defined in the global scope
    var ClassConstructor = window[className];
    if (typeof ClassConstructor === 'function') {
        return new ClassConstructor();
    } else {
        throw new Error('Class ' + className + ' not found.');
    }
}

// Function to create a form from an object and insert it into a div
// Example usage:
// Assuming 'MyClass' is a class defined somewhere in your code
// createFormAndInsertIntoDiv('MyClass', 'myFormContainer');
function createFormAndInsertIntoDiv(applyCallback, id, x, y, className, divId) {

    className = className + 'Model';
    divId = divId ? divId : 'annotationForm';

    // Create the object from the class name
    var obj = createObjectFromClassName(className);
    setPosition(obj, x, y, currentPage);
    console.log(obj);

    // Create a div to hold the form
    var formContainer = document.getElementById(divId);
    formContainer.dataid = id;

    var title = document.createElement('label');
    var titleArray = className.match(/[A-Z][a-z]+/g);
    titleArray = titleArray.slice(0, titleArray.length - 1);
    title.textContent = titleArray.join(' ');
    formContainer.appendChild(title);    

    // Create the form from the object and append it to the div
    createFormFromObject(obj, formContainer);
    addButtons(formContainer, applyCallback);
}

// Function to set the value of an object's property based on an input element
function setValueFromInput(obj, property, input) {
    var value;
    switch (input.type) {
        case 'checkbox':
            value = input.checked;
            break;
        case 'number':
            value = parseFloat(input.value);
            break;
        default:
            value = input.value;
    }
    obj[property] = value;
}

// Function to gather all form fields and set their values to the object
// Assuming the form has been generated and is accessible in the DOM
// var formContainer = document.getElementById('formContainer'); // Replace with your form container's ID
// Gather all form fields and set their values to the dataObject
// gatherFormFields(dataObject, formContainer);
// Now dataObject contains the values from the form fields
// console.log(dataObject);
function gatherFormFields(obj, parentElement) {
    var inputs = parentElement.getElementsByTagName('input');
    for (var i = 0; i < inputs.length; i++) {
        var input = inputs[i];
        var property = input.datakey;
        setValueFromInput(obj, property, input);
    }

    // Recurse for nested objects and arrays
    for (var property in obj) {
        if (obj.hasOwnProperty(property)) {
            var value = obj[property];
            if (typeof value === 'object' && value !== null) {
                if (Array.isArray(value)) {
                    value.forEach(function(item) {
                        gatherFormFields(item, parentElement);
                    });
                } else {
                    gatherFormFields(value, parentElement);
                }
            }
        }
    }
}

// Function to gather form fields and populate an object from an existing form
// Example usage:
// Assuming 'MyClass' is a class defined somewhere in your code
// and 'myForm' is the ID of your existing form container
// var filledObject = getFilledObjectFromForm('MyClass', 'myForm');
// Now filledObject contains the values from the form fields
// console.log(filledObject);
function getFilledObjectFromForm(className, formId) {
    // Create the object from the class name
    
    var obj = {};

    // Get the form container by its ID
    var formContainer = document.getElementById(formId);
    if (!formContainer) {
        throw new Error('Form container with ID ' + formId + ' not found.');
    }

    // Gather form fields and populate the object
    gatherFormFields(obj, formContainer);

    console.log(obj);
    // Return the filled object
    return obj;
}
