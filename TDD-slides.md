---
marp: true
theme: gaia
---
<!-- _class: lead-->
# Test Driven Development
## Agenda

- Warming up
- Wat, waarom en hoe TDD
- Pauze
- Introductie Unit Testing
- Korte pauze
- TDD Dojo
- Here, There, Everywhere: Hoe nu verder?

---
<!-- _class: lead-->
# Inleiding: Waarom TDD
## Demo: canonicalizer
---
# Code Rot

- Rigidity
- Fragility (Regression)
- Immobility
- Viscosity
- Needless complexity (gold plating, pre optimization)

---
# Hoe kan TDD helpen?

- Vermijden complexiteit
- Gold plating
- Pre-optimalisatie
---

# Misverstanden

- Kost teveel tijd
- Er is eerst een ontwerp nodig
- Je moet alle tests schrijven voor je begint met de implementatie
---
# Red Green Refactor
![bg right:50% w:500](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.xeridia.com%2Fsites%2Fdefault%2Ffiles%2Fcontenidos%2Fblog%2Ftest-driven-development.png&f=1&nofb=1&ipt=60664d009227b908755c3e658214c61355edc71bbb3a59df85166b071fc1fcce&ipo=images)

---
# Red Green Refactor
1. Schrijf een falende test
2. Schrijf code om de falende test te laten slagen
3. Refactor de code

--- 
# Drie wetten
1. Schrijf geen regel productiecode voordat je een falende test hebt geschreven.
2. Schrijf de meest minimale test die de code laat falen
3. Schrijf de meest minimale code om de test te laten slagen

---
# Technieken
- Faking
- Triangulation
- Obvious Implementation
---
<!-- _class: lead-->
# Demo
## TDD Canonicalizer
---
<!-- _class: lead-->
# Introductie Unit Testing met xUnit
---
# Soorten tests
- End to End tests
- Integratie tests
- Unit Tests
---

# Regels
- Fast
- Independent
- Repeatable
- Self validatable
- In time

---
<!-- _class: lead-->
#  Arrange, Act, Assert

---
# Het probleem van afhankelijkheden
- Dependency injection
- Test doubles: Fake, stub en mock
---
# Fake
Werkende implementatie van een class, maar afwijkend van product. Zoals een database repository.

---
# Stub
Een een voorgedefinieerde set aan gegevens die een productiedatabron zoals een service of database vervangt.

Wordt gebruikt om output van de SUT te verifieren.

---
# Mock
Een class die productiecode vervangt die operaties zonder verifieerbare output uitvoeren. Zoals een e-mail service.

Wordt gebruikt om het gedrag van de SUT te verifieren.


