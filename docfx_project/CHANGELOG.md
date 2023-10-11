# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/).

## 7.0.2 - 2023-09-25
### Changed
- Fix the OOM bug when uploading big blob.

## 7.0.1 - 2023-09-21
### Changed
- Fix the bug that incluster communication is lack of service name on the behand of host name.

## 7.0.0 - 2023-09-18
### Changed
- Change the image download and get image temp url related interface to support specifying the offset and length.

## 6.0.0 - 2023-08-03
### Changed
- Refine the upload related interface.
- Support specifying the filename when uploading blob.
- Support blob id with path.
- Add new interface to support upload from link.

## 5.0.0 - 2023-06-06
### Changed
- Change the upload related interface to support specifying the scanVirus or not.

## 4.0.1 - 2023-05-17
### Changed
- Downgrade the matrix client to 1.10.9 for monolith compatility issue.

## 4.0.0 - 2023-05-15
### Changed
- Change the upload related interface to support extraInfo for virus scan.

## 3.1.0 - 2023-05-08
### Changed
- Downgrade the System.Threading.Channels to 6.0.0

## 3.0.0 - 2023-04-04
### Changed
- Change the upload related interface.

## 2.7.0 - 2023-03-22
### Changed
- Support specifying the blob owner when uploading blob.

## 2.6.4 - 2023-03-10
### Changed
- Upgrade the matrix client to 1.10.12 and remove auth client package direct reference.

## 2.6.3 - 2023-03-08
### Changed
- Support specifying the delay parameter when calling delete interface.

## 2.6.2 - 2023-02-23
### Changed
- Fix the bug that the UploadAsync api isFullContainerName doesn't work. 

## 2.6.1 - 2022-12-08
### Changed
- Support the download stream position and length

## 2.6.0 - 2022-07-13
### Changed
- Support filename when get temp image url

## 2.5.3 - 2022-06-16
### Changed
- Wrap token client to the bss client internal

## 2.5.2 - 2022-04-28
### Changed
- Upgrade Matrix Client and Auth Client to support in-cluster domain

## 2.5.1 - 2022-04-08
### Changed
- Add parallel support for upload.

## 2.5.0 - 2022-03-10
### Changed
- Add GetBlobMetadataAsync interface.

## 2.4.0 - 2022-02-25
### Changed
- Support input blob id.

## 2.3.0 - 2021-12-02
### Changed
- Add interfaces to support copy blob.

## 2.2.0 - 2021-11-02
### Changed
- Add interfaces to support implicit container.

## 2.1.0 - 2021-09-23
### Changed
- Collect client SDK version, client executable name and client machine name, and send to BSS when calling BSS.

## 2.0.2 - 2021-09-17
### Changed
- Change the value of client executable name to the entry assembly name.
- Restore to use log message template.

## 2.0.1 - 2021-09-16
### Changed
- Add client SDK version, client executable name and client machine name to http request headers.

## 2.0.0 - 2021-09-06
### Changed
- Breaking change: Remove argument 'tokenClient' from method 'AddBlobStorageServiceClient', turn to get tokenClient from IOC.

## 1.3.0 - 2021-09-01
### Changed
- Add IncreaseBlobExpiration and RemoveBlobExpiration methods.

## 1.2.2 - 2021-08-06
### Changed
- Add SoftDelete method; Add public helper method to generate messageToSign.

## 1.2.1 - 2021-03-25
### Changed
- Fix expiry unit issue.

## 1.2.0 - 2021-03-02
### Changed
- Upgrade Matrix pack to 1.5.2.

## 1.1.4 - 2021-01-22
### Changed
- Create GetBlobSizeAsync GetBlobFormatAsync DoesBlobExistAsync.

## 1.1.3 - 2020-12-23
### Changed
- Enforce checking bss url returned from matrix

## 1.1.2 - 2020-12-04
### Changed
- Update clientAppVersion as optional argument; check if clientAppMetadata argument is null

## 1.1.1 - 2020-12-04
### Changed
- Remove BlobStorageServiceClientBuilder.Build() re-entry limitation
