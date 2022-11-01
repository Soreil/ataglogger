# ataglogger
A simple server which logs Atag One boiler state to an SQLite database

## Build dependencies

[dotnet 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

[dotnet entityframework global tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

## Runtime dependencies

java runtime environment (to communicate with the Atag One unit)

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

Copying over the publish folder and running the ```gas``` binary inside of there should now run the server!

## Usage

The database is stored in ```XDG_DATA_HOME``` on Linux (by default ```$home/.local/share```) and in ```C:\Users\USERNAME\AppData\Local``` on Windows.

## Common Issues

If the program crashes with a message it can't write to the database table you most likely have not yet ran the migrations.

If the program crashes claiming it can't find atag-one.jar it means you did not run the program from the correct folder. Run the program from a folder containing atag-one.jar .

## Disclaimer

This project is in no way associated with Atag and there are no guarantees about function whatsoever.

atag.jar is sourced from the [Atag One API](https://github.com/kozmoz/atag-one-api)
