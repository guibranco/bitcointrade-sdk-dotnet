# BitcoinTrade (brazilian exchange) SDK .NET

The [BitcoinTrade](https://bitcointrade.com.br) API client wrapper for .NET projects.

[![GitHub license](https://img.shields.io/github/license/guibranco/bitcointrade-sdk-dotnet)](https://github.com/guibranco/bitcointrade-sdk-dotnet)
[![Time tracker](https://wakatime.com/badge/github/guibranco/bitcointrade-sdk-dotnet.svg)](https://wakatime.com/badge/github/guibranco/bitcointrade-sdk-dotnet)


![Bitcointrade](https://raw.githubusercontent.com/guibranco/bitcointrade-sdk-dotnet/main/logo.png)


## CI/CD

| Build status | Last commit | Tests | Coverage | Code Smells | LoC | 
|--------------|-------------|-------|-------|-------|-------|
| [![Build status](https://ci.appveyor.com/api/projects/status/dekoywhywve3258w?svg=true)](https://ci.appveyor.com/project/guibranco/bitcointrade-sdk-dotnet) | [![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/bitcointrade-sdk-dotnet/main)](https://github.com/guibranco/bitcointrade-sdk-dotnet) | [![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/guibranco/bitcointrade-sdk-dotnet/main?compact_message)](https://ci.appveyor.com/project/guibranco/bitcointrade-sdk-dotnet/branch/main/tests) | [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=coverage&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet) | [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=code_smells&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet) | [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=ncloc&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet) | 

## Code Quality (main branch)

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/8bac161fe4584176bf8f681639c27ae9)](https://www.codacy.com/gh/guibranco/bitcointrade-sdk-dotnet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=gguibranco/bitcointrade-sdk-dotnet&amp;utm_campaign=Badge_Grade)
[![Codacy Badge](https://app.codacy.com/project/badge/Coverage/8bac161fe4584176bf8f681639c27ae9)](https://www.codacy.com/gh/guibranco/bitcointrade-sdk-dotnet/dashboard?utm_source=github.com&utm_medium=referral&utm_content=guibranco/bitcointrade-sdk-dotnet&utm_campaign=Badge_Coverage)

[![codecov](https://codecov.io/gh/guibranco/bitcointrade-sdk-dotnet/branch/main/graph/badge.svg)](https://codecov.io/gh/guibranco/bitcointrade-sdk-dotnet)
[![CodeFactor](https://www.codefactor.io/repository/github/guibranco/bitcointrade-sdk-dotnet/badge)](https://www.codefactor.io/repository/github/guibranco/bitcointrade-sdk-dotnet)

[![Maintainability](https://api.codeclimate.com/v1/badges/9608176406607e244eed/maintainability)](https://codeclimate.com/github/guibranco/bitcointrade-sdk-dotnet/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/9608176406607e244eed/test_coverage)](https://codeclimate.com/github/guibranco/bitcointrade-sdk-dotnet/test_coverage)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=alert_status)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet-dotnet)

[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=sqale_index)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet-dotnet)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet-dotnet)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=security_rating)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet-dotnet)

[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=bugs)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=guibranco_bitcointrade-sdk-dotnet&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=guibranco_bitcointrade-sdk-dotnet-dotnet)

---

## Installation

### Github Releases

[![GitHub last release](https://img.shields.io/github/release-date/guibranco/bitcointrade-sdk-dotnet.svg?style=flat)](https://github.com/guibranco/bitcointrade-sdk-dotnet) [![Github All Releases](https://img.shields.io/github/downloads/guibranco/bitcointrade-sdk-dotnet/total.svg?style=flat)](https://github.com/guibranco/bitcointrade-sdk-dotnet)

Download the latest zip file from the [Release](https://github.com/guibranco/bitcointrade-sdk-dotnet/releases) page.

### Nuget package manager

[![PacakgeName NuGet Version](https://img.shields.io/nuget/v/bitcointrade.svg?style=flat)](https://www.nuget.org/packages/bitcointrade/)
[![PacakgeName NuGet Downloads](https://img.shields.io/nuget/dt/bitcointrade.svg?style=flat)](https://www.nuget.org/packages/bitcointrade/)

| Package | Version | Downloads |
|------------------|:-------:|:-------:|
| **bitcointrade** | [![bitcointrade NuGet Version](https://img.shields.io/nuget/v/bitcointrade.svg?style=flat)](https://www.nuget.org/packages/bitcointrade/) | [![bitcointrade NuGet Downloads](https://img.shields.io/nuget/dt/bitcointrade.svg?style=flat)](https://www.nuget.org/packages/bitcointrade/) |

---

## Features

Implements all features of BitcoinTrade API available at [BitcoinTrade API Docs](https://apidocs.bitcointrade.com.br/)

- Public
- Market
- Transfers

---

## Usage

```cs

//sample CSharp code showing how to use the lib
var client = new BitcointradeClient();
client.CallSomeMethod();

```
