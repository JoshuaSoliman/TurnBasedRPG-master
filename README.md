BitBrawler – Turn-Based RPG Battle Simulator
============================================

README.txt

---

Characters Description:
-----------------------
Athlete - A star player of nearly every varsity sport, the Athlete is used
to high-stakes matches and impossible comebacks. They train harder than
anyone, both physically and mentally. While not the sharpest in class,
their grit is unmatched. When pushed to their absolute limit, when stress
overwhelms them, their body reacts with instinctual fury. Though they become
briefly dazed, their fighting spirit explodes, doubling their fighting power.

Brainiac - The Brainiac prefers to stay on the sidelines, watching and
calculating every move. Their intellect is razor-sharp, and they rarely need
to raise a hand to win. Instead, they break their opponents mentally,
wearing them down with clever tactics and psychological pressure. When they
succeed in overwhelming a foe’s mind, they strike directly at their health
with precision.

Clown - The Clown isn’t just class comic relief, they’re chaos incarnate.
They turn tension into performance, stress into energy. Every turn is a joke,
and every joke is a weapon. Sometimes they laugh so hard they stun even themself.
But that same humor fuels their resilience, no one brushes off stress quite like them.

New Student - Transferred from another school with no friends and little
confidence, the New Student began as an underdog. But each day, each mistake,
each encounter made them stronger. They quietly grow in skill turn after turn.
However, their inexperience still shows. When overwhelmed, the pressure can
break them, dragging all their progress down with it.

Prodigy - Born with talent that others train their whole lives for, the Prodigy
is dazzling and terrifying. They’re unpredictable, their mind sharp, their
strikes fierce. Their confidence borders on arrogance, and with good reason.
Whether in attack or manipulation, their brilliance shows up randomly but
brutally, leaving others wondering what just happened.

---

OOP Principles Applied:
-----------------------

1. Encapsulation:
   - Character stats and behaviors are bundled within the `Character` class.
   - Properties like `Hp`, `Attack`, and `Stress` are manipulated through
     controlled methods (`AttackTarget`, `Taunt`, etc.) rather than directly.
   - Randomness and stat effects are internally handled, preventing external tampering.

2. Abstraction:
   - Players interact with high-level actions like `AttackTarget()` and `Taunt()`
     without needing to understand internal stat calculations or conditions.
   - The complexities of passive effects and turn resets are hidden behind
     method calls like `EndTurnReset()`.

3. Polymorphism (Implied through class-based behavior):
   - Behavior varies depending on the `ClassType`, e.g., `Brainiac` has a different
     passive when taunting than `Clown`, though both use the same `Taunt()` method.
   - The `ApplyPassiveEffects()` method handles different logic depending on the class.

4. Composition:
   - The `Character` class is composed of enums (`ClassType`) and private helper
     methods to organize logic cleanly.

---

Challenges Faced:
-----------------

- We are new to OOP, game development, and C# logic structures.

- Balancing the Game:
  Designing fair and interesting stat distributions and passives took careful
  planning. Prodigy’s burst potential and Brainiac’s unique taunt interaction
  were especially tricky to tune.

- Complex Passive Interactions:
  Ensuring that passive abilities triggered correctly and didn’t stack or
  bug out was challenging, especially for Clown (random stun) and
  New Student (stat growth).

- State Management Between Turns:
  Managing temporary states like `IsDefending` and `IsStunned` required clear
  resetting logic to avoid unintended carryover effects between turns.

- OOP Design Decisions:
  Initially, it was tempting to write procedural code.
  Refactoring into methods and making character behavior class-dependent while
  sticking to clean OOP took discipline.
    - Keep all character-related logic inside the Character class.
    - Make sure each character behaves differently based on their class type.
    - Avoid writing a bunch of if-statements and repetitive code outside the class.

- Time and Resource Limitations:
  We worked under time pressure with limited access to
  tutorials or advanced tools. Understanding logic flow,
  testing mechanics, and debugging took longer than expected.

---

Despite all these challenges, we were able to complete a functional
turn-based RPG using proper OOP structure and customized character logic.
