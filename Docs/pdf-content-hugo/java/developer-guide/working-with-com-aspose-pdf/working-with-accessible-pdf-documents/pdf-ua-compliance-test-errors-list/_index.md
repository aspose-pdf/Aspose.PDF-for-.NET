---
title: PDF-UA Compliance Test - Errors List
type: docs
weight: 30
url: /java/pdf-ua-compliance-test-errors-list/
---

While doing PDF/UA compliance testing using Aspose.PDF API, you may be interested in knowing the error messages that you can get. These errors are of different types such as General, Text, Fonts, Headings, and several others. Information about such errors can be helpful in knowing the exact cause of the errors and their handling. In this article, we list the errors that can arise during PDF/UA compliance testing using the API.
### **General**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|5:1|Error|PDF/UA identifier missing|
|6.2:1.1|Error|Structural parent tree: Inconsistent entry found|
|7.1:1.1(14.8.1)|Error|Document is not marked as tagged|
|7.1:1.1(14.8)|Error|[OBJECT_NAME] object not tagged|
|7.1:1.2(14.8.2.2)|Error|Artifact present inside tagged content|
|7.1:1.3(14.8.2.2)|Error|Tagged content present inside an artifact|
|7.1:2.1|Warning|Structure tree missing|
|7.1:2.2|Warning|‘Document’ structure element found which is not a root element|
|7.1:2.3|Warning|‘[ELEMENT_NAME]’ structure element used as root element|
|7.1:2.4.1|Warning|Possibly inappropriate use of a ‘[ELEMENT_NAME]’ structure element|
|7.1:2.4.2|Error|Invalid use of a ‘[ELEMENT_NAME]’ structure element|
|7.1:2.5|Warning|Possibly wrong nested ‘[ELEMENT_NAME]’ struct element into StructTreeRoot|
|7.1:3(14.8.4)|Error|Non-standard structure type ‘[TYPE_NAME]’ is neither mapped to a standard structure type nor to another non-standard structure type|
|7.1:4(14.8.4)|Warning|Standard structure type ‘[TYPE_NAME]’ is remapped to ‘[TYPE_NAME]’|
|7.1:5|Need check manual|Color contrast|
|7.1:6.1|Error|XMP metadata missing in document|
|7.1:6.2|Error|Title missing in document’s XMP metadata|
|7.1:6.3|Warning|Title is empty in document’s XMP metadata|
|7.1:7.1(12.2)|Warning|‘ViewerPreferences’ dictionary missing|
|7.1:7.2(12.2)|Error|‘DisplayDocTitle’ entry is not set|
|7.1:8(14.7.1)|Error|‘Suspects’ entry is set|
|7.1:9.1(14.7)|Error|‘StructParents’ key missing in page|
|7.1:9.2(14.7)|Error|‘StructParent’ entry missing in the annotation|
|7.1:9.3(14.7)|Error|Entry for given ‘StructParents’ not found|
### **Text**

|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.2:1|Need check manual|Logical Reading Order|
|7.2:2(14.8.2.4.2)|Error|Characters in a text object cannot be mapped to Unicode|
|7.2:3.1(14.9.2.2)|Error|Natural language for text object cannot be determined|
|7.2:3.2(14.9.2.2)|Error|Natural language of alternative text cannot be determined|
|7.2:3.3(14.9.2.2)|Error|Natural language of actual text cannot be determined|
|7.2:3.4(14.9.2.2)|Error|Natural language of expansion text cannot be determined|
|7.2:4(14.9.4)|Error|Stretchable character no tagged using ActualText|
### **Fonts**

|**Clause**|**Severity**|**Message**|
| :- | :- | :- |
|7.21.3.1|Error|Character collection in CIDFont is not compartible with character collection of internal CMap|
|7.21.3.2|Error|CIDToGIDMap is not embedded or incomplete in font ‘[FONT_NAME]’|
|7.21.3.2|Error|CMap is not embedded for font ‘[FONT_NAME]’|
|7.21.4.2|Error|CIDSet is missing or incomplete for font ‘[FONT_NAME]’|
|7.21.4.2|Error|Glyphs missing in embedded font ‘[FONT_NAME]’|
|7.21.6|Error|Non-symbolic TrueType font ‘[FONT_NAME]’ has no cmap entries|
|7.21.6|Error|Encoding entry prohibited for symbolic TrueType font ‘[FONT_NAME]’|
|7.21.6|Error|Incorrect encoding is used for TrueType font ‘[FONT_NAME]’|
|7.21.6|Error|Incorrect “Differences” array for non-symbolic TrueType font ‘[FONT_NAME]’|
### **Graphics**

|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.3:1(14.8.4.5)|Error|‘[ELEMENT_NAME]’ element on a single page with no bounding box|
|7.3:2|Error|Alternative text missing for ‘[ELEMENT_NAME]’ structure element|
|7.3:3|Error|Caption accompanying figure missing|
|7.3:4(14.8.4.5)|Error|Graphics object appears between the BT and ET operators|
### **Headings**

|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.4.2:1|Error|The first heading is not on the first level|
|7.4.2:2|Error|Numbered heading skips one ore more heading levels|
|7.4.4:1|Error|‘H’ and ‘Hn’ structure elements found|
|7.4.4:2|Error|More than one ‘H’ structure element inside the parent structure element|
### **Tables**

|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.5:1|Warning|Irregular table row|
|7.5:2|Error|Table header cell has no associated subcells|
|7.5:3.1|Warning|Table headers missing|
|7.5:3.2|Warning|Table summary missing|
### **Lists**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.6:1|Error|‘LI’ structure element must be a child of ‘L’ element|
|7.6:2|Error|‘Lbl’ and ‘LBody’ structure element must be children of ‘LI’ element|

### **Notes and references**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.9:2.1|Error|ID missing in ‘Note’ structure element|
|7.9:2.2|Error|ID entry in ‘Note’ structure element is not unique|

### **Optional content**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.10:1|Error|‘Name’ missing in optional content configuration dictionary|
|7.10:2|Error|Optional content configuration dictionary contains ‘AS’ key|

### **Embedded files**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.11:1|Error|‘F’ or ‘UF’ key missing in the file specification|
|7.11:2|Warning|‘Desc’ key missing in the file specification|

### **Digital signatures**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.13:1|Error|Signature form field ‘[FIELD_NAME]’ does not conform to the specification|
|7.13:2.1|Error|Natural language of an alternate name of a form field ‘[FIELD_NAME]’ cannot be determined|
|7.13:2.2|Error|Alternate field name entry missing in form field ‘[FIELD_NAME]’|

### **Non-interactive forms**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.14:1|Error|‘PrintField’ attribute missing in non-interactive form item|

### **XFA**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.15:1|Error|PDF contains a dynamic XFA form|

### **Security**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.16:1(7.6.3.2)|Error|Security settings block assistive technologies from accessing document’s content|
|7.16:2(7.6.3.2)|Error|Conversion is not allowed by permission restrictions|

### **Navigation**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.17:1|Error|Document Outlines Error|
|7.17:2|Error|Natural language of outlines can be determined|
|7.17:3|Need manual check|Semantically appropriate Page Labels|

### **Annotations**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.18.1:1|Error|Natural language of Contents entry cannot be determined|
|7.18.1:2|Error|Alternative description missing for an annotation|
|7.18.1:3|Error|Annotation is not nested inside an ‘Annot’ structure element|
|7.18.2:1|Error|An annotation with subtype undefined in ISO 32000 does not meet 7.18.1|
|7.18.2:2|Error|An annotation of subtype TrapNet exists|
|7.18.3:1|Error|Tab order entry in page with annotations not set to ‘S’ (Structure)|
|7.18.4:1|Error|‘Widget’ annotation not nested inside a ‘Form’ structure element|
|7.18.5:1|Error|‘Link’ annotation is not nested inside a ‘Link’ structure element|
|7.18.6.2:1|Error|CT key is missing from the media clip data dictionary|
|7.18.6.2:2|Error|Alt key is missing from the media clip data dictionary|
|7.18.7:1|Error|File attachment annotation. ‘F’ or ‘UF’ key missing in file specification|
|7.18.7:2|Warning|File attachment annotation. ‘Desc’ key missing in file specification|
|7.18.8:1|Error|A PrinterMark annotation is included in logical structure|
|7.18.8:2|Error|The appearance stream of a PrinterMark annotation is not marked as Artifact|

### **Actions**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.19:1|Need check manual|Actions were found. Need to check actions according to specification PDF/UA manually|

### **XObjects**


|**Code**|**Severity**|**Message**|
| :- | :- | :- |
|7.20:1|Error|Reference XObject shall not be used in conforming PDF/UA file|
|7.20:2|Error|The content of Form XObject isn’t incorporated into structure elements|

