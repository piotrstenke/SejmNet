<div align="left">
	<a href="https://www.nuget.org/packages/SejmNet">
		<img src="https://img.shields.io/nuget/v/SejmNet?style=flat-square&color=seagreen" alt="Version"/>
	</a>
	<a href="https://www.nuget.org/packages/SejmNet">
		<img src="https://img.shields.io/nuget/dt/SejmNet?style=flat-square&color=blue" alt="Downloads"/>
	</a> <br />
	<a href="https://github.com//piotrstenke/SejmNet/blob/master/LICENSE.md">
		<img src="https://img.shields.io/github/license/piotrstenke/SejmNet?color=orange&style=flat-square" alt="License"/>
	</a>
</div>

<div align="center">
		<img src="../../img/icons/logo-256.png" alt="Sejm logo"/>
</div>

# SejmNet

**SejmNet** is a C# production-ready client library for the official API of the Parliament of the Republic of Poland (Sejm) available at https://api.sejm.gov.pl.

## Supported platforms

Currently, the package supports .NET 8 or later.

## Usage

To get access to the API, simply create a new instance of *SejmNet.SejmClient* and call an appropriate method.

```csharp
using SejmNet;
using SejmNet.Models;

SejmClient client = new();

// Returns information about all clubs in the 10th term of the parliament.
Club[] clubs = client.GetClubs(10);

// Returns information about a parliament member with ID 148 in the 10th term of the parliament.
ParliamentMember? member = client.GetMember(10, 148);

```

## Known issues

 - ISejmClient.GetPrints() - */sejm/term\{term\}/prints* - tends to have EXTREMALY low performance (like, requests can last for literal minutes), using this method should be avoided if possible.

 - ISejmClient.GetPrints() - */sejm/term\{term\}/prints* - the 'sort_by' parameter is not supported by the library, as it does not seem to work.

 - IEliSejmClient - */eli/changes/acts* - this action is not implemented, it seems like it doesn't work properly.

## Contributing

Contributions are more than welcome, feel free to open a new issue or create a pull request.
