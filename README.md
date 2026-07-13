⸻

Venture – Game Design Document (v0.1)

Overview

Title: Venture

Genre:
3D Fantasy Action-Adventure RPG

Engine:
Unity 6

Perspective:
First-person

Theme:
Ancient mythology, exploration, progression, and player choice.

⸻

Core Premise

The player awakens within a mysterious divine realm with no memories.

Before them stand two ancient temples representing the Greek and Roman civilizations.

The player’s first decision determines their ancestry, which becomes the foundation of their entire build.

⸻

Opening Sequence

Chapter 1

* Fade in
* Player gains movement
* Two temples become visible
* Objective appears:

Choose your ancestry.

The player may approach either temple.

⸻

Temple Selection

Each temple contains:

* Interaction trigger
* “Press E” prompt
* Temple-specific mythology

Greek Temple

↓

Roll Greek ancestor

Roman Temple

↓

Roll Roman ancestor

⸻

Ancestor System

Each ancestor contains:

* Name
* Mythology
* Rarity
* List of Attributes

Example

Ares

* Mythology: Greek
* Rarity: Common
* Attributes
    * War
    * Rage
    * Leadership

⸻

Attribute System

Every ancestor has multiple attributes.

Each attribute contains randomized buffs.

Example

War

Possible Buffs

* Strength +8–20%
* Critical Damage +5–15%
* Attack Speed +3–10%

Every playthrough rolls different values.

⸻

Stat Sheet

After choosing a temple:

1. Random ancestor is selected
2. Buffs are rolled
3. Stat sheet opens

Displays

Ancestor

* Name
* Mythology
* Rarity

Base Stats

(Current placeholders)

* Health
* Mana
* Stamina
* Strength
* Speed
* Defense

Attributes

Clickable list

Selecting an attribute displays its buffs.

⸻

Current Systems

Working

✔ Third-person movement

✔ Camera

✔ Jumping

✔ Greek temple interaction

✔ Ancestor database

✔ Attribute database

✔ Attribute generation

✔ Random buff rolling

✔ Stat sheet UI

✔ Attribute selection UI

⸻

Planned Intro Flow

Spawn
↓
Walk to Temple
↓
Press E
↓
Choose Mythology
↓
Roll Ancestor
↓
Generate Buffs
↓
Open Stat Sheet
↓
Accept Ancestor
↓
Begin Adventure

⸻

Future Systems

Combat

* Melee
* Ranged
* Magic
* Dodging
* Blocking
* Combos

⸻

Progression

* Experience
* Levels
* Skill Trees
* Equipment
* Abilities

⸻

World

Multiple mythologies

Currently planned

* Greek
* Roman

Future

* Egyptian
* Norse
* Japanese
* Celtic
* Hindu
* Yoruba
* Aztec
* Chinese

⸻

Story

Primary antagonist

The Null

A mysterious force erasing civilizations from existence.

The player must uncover their true identity while preventing every mythology from being consumed.

⸻

Technical Architecture

TempleInteraction
        │
        ▼
AncestryManager (planned)
        │
        ▼
AncestorDatabase
        │
        ▼
PlayerAncestry
        │
        ▼
AttributeGenerator
        │
        ▼
AncestorStatSheetUI

⸻

Immediate Development Roadmap

Phase 1 (Current)

* ✅ Movement
* ✅ Camera
* ✅ Jump
* ✅ Greek temple
* ⏳ Roman temple
* ⏳ Accept button
* ⏳ Intro completion

Phase 2

* Ability system
* Combat
* Enemies
* Saving/loading
* UI polish

Phase 3

* First explorable region
* Quests
* NPCs
* Loot
* Boss fight

⸻
