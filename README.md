# Globags

## Introduction

A sample solution created for a mock project &#39;Globags&#39; using Sitecore 9.3, Sxa 9.3, Sxa@Cli – Scriban, Unicorn and Docker. The solution is designed using Helix principals with automatic build that publishes files to mapped volumes. The Sitecore instances are created based on simple XM topology.

![Home Page](https://github.com/nkdram/gb/blob/develop/images/Homepage.png)

## Summary :

Aim of this project is to design a Sitecore solution using latest standard that can be easily used by multiple developers in a team using Docker. It is also to show case how SxA OOTB features can be used to design a website by creating custom Features, cloning components, creating custom rendering variants and using Scriban template engine.

![Variants Page](https://https://github.com/nkdram/gb/blob/develop/images/Variants.png)

##

![Search Page](https://https://github.com/nkdram/gb/blob/develop/images/SearchPage.png)

##

![Sxa Cli](https://https://github.com/nkdram/gb/blob/develop/images/Scriban.png)

## Pre-requisites

##

1. Windows 10.0.18362 Build
2. Powershell 5
3. Docker for windows – Running on Windows container
4. Docker hub registry access

##

## Steps to Configure

##

1. Copy your Sitecore License to &#39;C:\license&#39; folder
2. Update &#39;Debugger&#39; variable in .env file to match with your VS debugger path
3. Add host entry for CMS / CD - globags.sc.cms , globags.sc.dev with loop back ips :
 127.0.0.1 globags.sc.cd
 127.0.0.1 globags.sc.cms
4. Stop IIS – or sites that use 443 port : This is important as the &quot;Traefik&quot; uses 443 port to route requests to above instances.
5. Finally Run ./init.ps1 from Solution directory. This script pulls images from Registry and creates required instances as containers in local machine. Once this script completes , please access the cms site [https://globags.sc.cms/sitecore/login]
**\*\* note – currently requests are only working with https – so please make sure https scheme is added while accessing the site.**

###

###


##