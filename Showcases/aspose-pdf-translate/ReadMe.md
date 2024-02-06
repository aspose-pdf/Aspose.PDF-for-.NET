# GroupDocs Translate API Integration

This ASP.NET 6 application integrates with the GroupDocs Translate API to translate PDF documents from English, French, German, Italian to global languages.

## Prerequisites

Before running this application, make sure you have:

- Registered on [GroupDocs Translation](https://products.groupdocs.cloud/translation/family/) and obtained the `Translate_ClientId` and `Translate_ClientSecret` credentials.
- Set up environment variables `Translate_ClientId` and `Translate_ClientSecret` with your credentials.

## API Endpoints

### POST /api/translate?from={sourceLang};to={targetLang}

This endpoint translates documents from the source language to the target language. Replace `{sourceLang}` and `{targetLang}` with language codes (e.g., `en` for English, `fr` for French).

### GET /api/status/{documentId}

This endpoint retrieves the translation status of a document using its `documentId`.

### GET /api/download/{documentId}

This endpoint allows downloading the translated document by specifying its `documentId`.

## Configuration

In the `config.js` file, you can configure the frontend settings:

```json
{
  "AppURL": "http://localhost:5240/",
  "WebApiPath": "http://localhost:5240/api/",
  "MaximumUploadFiles": 10,
  "UploadOptions": [
    "PDF", "HTML", "PPT", "PPTX", "PPTM", "TXT", "CSV", "DOC", "DOCM", "DOCX", "MD", "ODP", "ODS", "ODT", "RESX", "RTF", "SRT", "TSV", "XLS", "XLSM", "XLSX"
  ]
}
```

* AppURL: The base URL of the application.
* WebApiPath: The base URL for API endpoints.
* MaximumUploadFiles: Maximum number of files allowed to upload.
* UploadOptions: Supported file formats for upload.

## Running the Application

1. Clone this repository.
2. Set up environment variables Translate_ClientId and Translate_ClientSecret with 3. your credentials.
4. Navigate to the project directory.
5. Run dotnet run to start the application.
6. Access the application at the specified URL (default: http://localhost:5240/).

## License

This project is licensed under the MIT License.

Feel free to modify the contents according to your specific requirements or add any additional information as needed.
