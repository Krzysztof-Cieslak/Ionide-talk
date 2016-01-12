(**
- title : Ionide and state of F# Open Source Ecosystem
- description : Ionide and state of F# Open Source Ecosystem
- author : Krzysztof Cieslak
- theme : Sky
- transition : default

***

### Ionide and state of F# Open Source Ecosystem


** Krzysztof Cieslak (@k_cieslak) **

' Parę slow o sobie
' Full stack (SQL + C# + TS) at work
' Small F# projects
' Open Source contributor

***

### About F#

- Statically typed (ML family)
- Multi-pardigm
- Functional first
- Open Source
- Community driven

' Stworzony przez Don'a Syma (generics in .Net)
' Functional first (ale mozna OO)
' Integracja z .Net ale nie tylko - mono, iOs, Androind, JavaScript, GPU (CUDA)

***

OpenSource = code + Community

---

### F# Software Foundation

- October 2012
- Managing development of F# language
- Formal non-profit organization
- Democratic elections

---

### F# 4.0

- 38 contributors
- all work done and discussed on GitHub
- Community effort

' ponad 75% contributorow nie jest pracownikami MSFT lub MSFT Research, a czlonkami spolecznosci F#

***

### Paket

- alternative NuGet client (and more)
- solution level version resolving
- no version in path
- no merge conflicts after version update
- GitHub dependencies
- HTTP dependencies
- group features
- upcoming full Git support
- building dependencies from source

' Nie ma nic wspolnego z F# ( no oprocz tego ze w F# jest napisany)
' Moze byc uzywany bez problemow z C#, lub nawet w nie .Netowych projektach
' Brak wersji w sciezce powoduje brak konfliktow merge'owanai w plikach fsproj czy csproj
' Command line, integracja z VS, XS i Atomem.

---

### Stats

- 2 years old
- 5090 commits
- 939 releases
- 112 contributors
- 439 PRs merged

***

### FAKE

- build automation system
- DSL build on top of F#
- helpers for everything in .Net space

' F# make
' podobny do PSAKE czy rake
' nie wymaga duzej znajomosci F# - to jest glownie DSL
' pozwala na definiowanie taskow i zaleznosci miedzy nimi
' parallel execution, caching
' heleprs for everything (test, GitHub, Octopus deploy, i setki innych rzeczy)

---

### Stats

- 5 years old
- 4914 commits
- 1472 releases
- 177 contributors
- 572 PRs merged

***

### Suave

- simple web development F# library
- lightweight web server
- set of combinators to manipulate route flow and task composition
- APIs and server generated views

' programowanie funkcyjne swietnie nadaje sie do backend programming
' serwer HTTP to funkcja: HttpRequest -> HttpResponse
' latwosc budowania aplikacji po przez komponowanie funkcji ( czyli output funkcji A idzie jako input do funkcji B)
' uzywana przez wiele projektow takich jak FsReveal, FsLab, FSAC

---

### Stats

- 3 years old
- 1224 commits
- 56 releases
- 24 contributors
- 119 PRs merged

***

### Ionide

- an Atom Editor package suite for cross platform F# development.
- F# editing features - autocomplete, tooltips, error highlighting
- Paket integration
- FAKE integration
- integration with F# yeoman generator
- integration with Suave (and any other web based solution)

' tworzenie pluginow w F# i kompilowanie do JS
' specjalnie nacisk polozony jest na integracje z narzedzialmi zbudowanymi przez community
' brak wsparcia dla NuGet'a czy MsBuild natomiast jest wsparcie dla Paket i FAKE
' tworzenie nowych projektow za pomoca F# yeman generator
' wsparcie dla Suave pozwala na latwe tworzenie projektow wykorzystujacych FsLab czy FsReveal

---

### Stats

- 7 months old
- 470 commits
- 105 releases
- 13 contributors
- 57 PRs merged

***

### Any questions?

***

### Links

- Paket - http://fsprojects.github.io/Paket/
- FAKE - http://fsharp.github.io/FAKE/
- Ionide - http://ionide.io

---

### More about F#

* http://fsharp.org/
* http://fpchat.com/
* http://dungpa.github.io/fsharp-cheatsheet/
* http://fsharpforfunandprofit.com/
* http://fsprojects.github.io/
* http://tomasp.net/

*)
