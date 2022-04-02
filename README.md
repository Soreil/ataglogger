# ataglogger
A simple server which logs Atag One boiler state to an SQLite database

## Build dependencies

dotnet 6

dotnet entityframework global tools

## Runtime dependencies

java runtime environment

## Installation

```git clone https://github.com/Soreil/ataglogger```
```cd ataglogger```
```dotnet restore```
On the target system we will have to create the database. If this is the current system: 
```dotnet ef database update```
If we are going to deploy the server to another system it is most convenient to build an all in one binary that will have to be ran once before running the server.
```dotnet ef migrations bundle --runtime RUNTIME```
If running the server on a different operating system or architecture append the correct [Runtime Identifier](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog)

Next, run the generated bundle on the target system as the intended user for running the server (Use sudo if it's meant to be a system service on Linux)

Build the server
```dotnet publish --runtime RUNTIME```

The resulting binary will be in ```bin\Debug\net6.0\ARCHITECTURE\publish```
Copying over the publish folder and running ```gas``` inside of there should now run the server!

## Usage

The database is stored in ```XDG_DATA_HOME``` on Linux (by default ```$home/.local/share```) and in ```C:\Users\USERNAME\AppData\Local``` on Windows.

## Disclaimer

This project is in no way associated with Atag and there are no guarantees about function whatsoever.
