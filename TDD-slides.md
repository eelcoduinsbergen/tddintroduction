---
marp: true
theme: gaia
---
<!-- _class: lead-->
# Test Driven Development
## Agenda

- Warm-up
- Introductie TDD
- TDD Dojo
- Here, There, Everywhere: hoe nu verder?

---
<!-- _class: lead-->
# Onderwerpen

- Inleiding - Waarom TDD?   
- Code rot
- Hoe kan TDD helpen?
- Misverstanden
- "red-green-refactor"
- De drie wetten
- TDD en unit tests
- Wanneer faalt TDD?


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
# F.I.R.S.T.

- Fast
- Indipendent
- Repeatable
- Self validatable
- In time

---
<!-- _class: lead-->
# Demo
## TDD Canonicalizer