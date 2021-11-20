# VACMESharp
An ACME to Hashicorp Vault bridge.

## What?
It's a well-known and annoying problem that Hashicorp Vault doesn't support the ACME protocol. This is especially annoying if you're using a reverse proxy like Traefik.

There is support for Vault in Traefik but this feature is only available in the Enterprise edition and most of the people (including me) are not keen on paying for a simple feature that would make dynamic certificate provisioning and renewing dead simple. There is a whole [issue]() about this.

On the other hand, Hashicorp could decide to implement (authenticated) ACME but they simply [refuse]() to do so.

Now, the proposed solution is this: a bridge.

## The solution
This is VACMESharp. An ACME server and Vault client. This project aims to do what Hashicorp Vault and Traefik failed to do. This would not be possible with the help of two libraries:

- [VaultSharp](https://github.com/rajanadar/VaultSharp) (written by [Raja Nadar](https://github.com/rajanadar))
- [ACME-Server](https://github.com/PKISharp/ACME-Server) (written by the great people from [PKISharp](https://github.com/PKISharp))

## How to build
### Docker
Since most people run Traefik in a container (including me), there is the possibility to build a VACMESharp container. You'll need the [Docker environment](https://www.docker.com/).

Steps to build:
- `docker build -t vacme VACMESharp/Dockerfile`

Or you could just `docker pull` my pre-built image [0x5ecf4ult/vacme]() ;-)

### Bare metal
If you somehow decide that it'd be smarter to run VACMESharp bare-metal, you'll need the `dotnet` toolchain. You can find it over at its [official homepage](https://dotnet.microsoft.com/).

Steps to build:
- `dotnet build -c Release`

This will build a `.dll` binary in `VACMESharp/bin/Release/net5.0/`.

## Usage
Just point your Traefik installation at VACME and let the magic happen ;-)

### Example CLI:
```yaml
TODO
```

### Example YAML:
```yaml
TODO
```

### Example TOML:
```toml
TODO
```