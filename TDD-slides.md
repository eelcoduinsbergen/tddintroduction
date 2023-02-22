---
marp: true
theme: gaia
---

# Onderwerpen

- Inleiding
- Wat is TDD en waarom hebben we het nodig?    
- Misverstanden over TDD.
- "red-green-refactor"
- De drie wetten van TDD
- TDD en unit tests
- Wanneer faalt TDD?
- Code rot, SOLID
- TDD Dojo
- Meer leren en verder lezen.

---
<!-- _class: lead-->
# Inleiding

---
# Waarom TDD
Test Driven Development of Test Driven Design

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