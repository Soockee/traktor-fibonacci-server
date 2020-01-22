# C# Instrumentalized HTTP Server

Server calculates the N-th Fibonacci number

## Requirements
* Docker

or 

* dotnet core sdk 3.1

## Configuration
Server runs on port 8084

Server is configured via enviromental variables

* REGISTRY_IP
* REGISTRY_PORT
* AGENT_IP
* AGENT_PORT
* REPORTER_PORT

### REGISTRY_IP & REGISTRY_PORT

Address which is used by the tracer. Connections to the Tracer-Registry

### AGENT_IP & AGENT_PORT

Address which is used by the tracer. Send the reported spans via udp to address

### REPORTER_PORT

Port which is used by the tracer. The internal Tracer-Reporter binds a socked with the REPORTER_PORT

## Usage

```
http POST localhost:8084 N:=3
```