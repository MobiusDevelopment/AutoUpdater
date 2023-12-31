# AutoUpdater Package Creator
<img src="https://raw.githubusercontent.com/MobiusDevelopment/AutoUpdater/master/AutoUpdaterPackageCreator.png"/>

## Overview
AutoUpdaterPackageCreator is a VB.NET application designed to facilitate the creation of update packages. It generates individual ZIP files for each file in a source directory, maintaining the original directory structure, and creates `version.txt` and `filelist.txt` for version tracking and SHA256 hashes of the files, respectively.

## Features
- Easy selection of source and output directories.
- Version number entry for package tracking.
- Automated generation of `version.txt` and `filelist.txt`.
- ZIP file creation for each file in the source directory, preserving directory structure.
- SHA256 hash generation for file integrity verification.

## Installation
The only thing you need to do is open AutoUpdaterPackageCreator.sln with Visual Studio and hit F5 to run it.<br>
No specific installation process required. The application runs directly from the executable in the Windows environment.

## Usage
1. **Select Source Folder:** Click on the related `Select` button to choose the source directory containing the files for packaging.
2. **Select Output Folder:** Click on the related `Select` button to define the destination directory for the generated packages.
3. **Version Input:** Enter the version number in `Version` textbox. This will be used in `version.txt`.
4. **Generate Packages:** Press `Generate` to initiate the packaging process.

## Detailed Functionality
- **Folder Checks:** Ensures the selected source and output folders meet the necessary conditions (non-empty source, empty destination).
- **Version Input Restriction:** Only numeric inputs allowed for version number.
- **File Processing:** Processes files in the source directory recursively, computes SHA256 hashes, and packages them into ZIP files.
- **Progress Tracking:** Utilizes a progress bar to display progress.
- **Error Handling:** Provides user alerts for issues related to folder selection or file processing.


## File Handling and Deployment

### Generated Files
AutoUpdaterPackageCreator generates several files during its operation:
- `version.txt`: Contains the version number of the package.
- `filelist.txt`: Lists all files with their respective SHA256 hashes.
- Individual `.zip` files for each item in the source directory, preserving the directory structure.

### Moving Generated Files
Once the packaging process is complete, the generated files are found in the specified output folder. These files include the `version.txt`, `filelist.txt`, and a `zips` folder containing ZIP files for each item.

To deploy these files for an update mechanism, follow these steps:

1. **Web Server Setup:** Ensure you have a web server configured to serve files. In the provided code, the base URL is set as `"http://127.0.0.1/updater/"`. Adjust this to your actual server's URL.

2. **Upload Files:**
   - Upload the `version.txt` and `filelist.txt` directly to the root of the designated path on your web server (e.g., `http://yourserver.com/updater/`).
   - Upload the contents of the `zips` folder to a subdirectory on your web server, typically named `zips` (e.g., `http://yourserver.com/updater/zips/`).

3. **Client Application Configuration:**
   - The client application should be configured to check for updates from your web server. This is typically done by setting the `baseURL` in the application to match your web server's URL.

### Note
Ensure that the web server's directory structure matches the expected paths set in the application code. For example, if your application expects `version.txt` at `http://yourserver.com/updater/version.txt`, it should be placed accordingly on the server.

---
AutoUpdater Package Creator - Automating package creation with ease and reliability.