using HxH_RPG_Environment.Domain.Abilities;
using HxH_RPG_Environment.Domain.Attributes;
using HxH_RPG_Environment.Domain.Enums;
using HxH_RPG_Environment.Domain.Experiences;
using HxH_RPG_Environment.Domain.Mentals;
using HxH_RPG_Environment.Domain.Physicals;
using HxH_RPG_Environment.Domain.Skills;
using HxH_RPG_Environment.Domain.Spirituals;
using HxH_RPG_Environment.Domain.Status;

namespace HxH_RPG_Environment.Domain.Sheets;

public class CharacterSheetFactory()
{
  private const double CHARACTER_COEFFICIENT = 10.0;
  private const double TALENT_COEFFICIENT = 10.0;
  private const double PHYSICAL_COEFFICIENT = 20.0;
  private const double MENTAL_COEFFICIENT = 15.0;
  private const double SPIRITUAL_COEFFICIENT = 5.0;
  private const double SKILLS_COEFFICIENT = 5.0;
  private const double PHYSICAL_ATTRIBUTE_COEFFICIENT = 5.0;
  private const double MENTAL_ATTRIBUTE_COEFFICIENT = 3.0;
  private const double PHYSICAL_SKILLS_COEFFICIENT = 1.0;
  private const double MENTAL_SKILLS_COEFFICIENT = 2.0;
  private const double SPIRITUAL_PRINCIPLE_COEFFICIENT = 1.0;

  public CharacterSheet Build(Profile profile)
  {
    Experience exp = new(new ExpTable(CHARACTER_COEFFICIENT));
    CharacterExp characterExp = new(exp);

    PersonAbilities abilities = BuildPersonAbilities(characterExp);

    Ability physAbility = abilities.Get(AbilityName.PHYSICALS);
    PhysicalAttributes physAttrs = BuildPhysAttrs(physAbility);

    Ability mentalAbility = abilities.Get(AbilityName.MENTALS);
    MentalAttributes mentalAttrs = BuildMentalAttrs(mentalAbility);

    StatusManager status = BuildStatusManager();

    Ability skills = abilities.Get(AbilityName.SKILLS);
    PhysicalSkills physSkills = BuildPhysSkills(
      status, skills, physAbility, physAttrs.Attributes
    );
    MentalSkills mentalSkills = BuildMentalSkills(
      skills, mentalAbility, mentalAttrs.Attributes
    );

    Ability spiritAbility = abilities.Get(AbilityName.SPIRITUALS);
    Hatsu hatsu = BuildHatsu(spiritAbility);
    SpiritualPrinciples spiritPrinciples = BuildSpiritPrinciples(
      status.Get(StatusName.Aura), spiritAbility, hatsu
    );

    return new CharacterSheet(profile, abilities, status);
  }

  public PersonAbilities BuildPersonAbilities(IEndCascadeUpgrade characterExp)
  {
    Dictionary<AbilityName, Ability> abilities = [];

    Experience talentExp = new(new ExpTable(TALENT_COEFFICIENT));
    Talent talent = new(talentExp);

    Experience physicalExp = new(new ExpTable(PHYSICAL_COEFFICIENT));
    abilities.Add(AbilityName.PHYSICALS, new(physicalExp, characterExp));

    Experience mentalExp = new(new ExpTable(MENTAL_COEFFICIENT));
    abilities.Add(AbilityName.MENTALS, new(mentalExp, characterExp));

    Experience spiritualExp = new(new ExpTable(SPIRITUAL_COEFFICIENT));
    abilities.Add(AbilityName.SPIRITUALS, new(spiritualExp, characterExp));

    Experience skillsExp = new(new ExpTable(SKILLS_COEFFICIENT));
    abilities.Add(AbilityName.SKILLS, new(skillsExp, characterExp));

    // TODO: knowlegde exp

    return new PersonAbilities(abilities, talent);
  }

  public PhysicalAttributes BuildPhysAttrs(ICascadeUpgrade physAbilityExp)
  {
    Dictionary<AttributeName, IGameAttribute> attributes = [];

    Experience exp = new(new ExpTable(PHYSICAL_ATTRIBUTE_COEFFICIENT));
    PrimaryAttribute primaryAttribute = new(exp, physAbilityExp);

    PrimaryAttribute constitution = primaryAttribute.Clone();
    PrimaryAttribute strength = primaryAttribute.Clone();
    MiddleAttribute defense = new(exp.Clone(), [constitution, strength]);
    attributes.Add(AttributeName.Constitution, constitution);
    attributes.Add(AttributeName.Strength, strength);
    attributes.Add(AttributeName.Defense, defense);

    PrimaryAttribute agility = primaryAttribute.Clone();
    MiddleAttribute velocity = new(exp.Clone(), [strength, agility]);
    attributes.Add(AttributeName.Agility, agility);
    attributes.Add(AttributeName.Velocity, velocity);

    PrimaryAttribute flexibility = primaryAttribute.Clone();
    MiddleAttribute actionSpeed = new(exp.Clone(), [agility, flexibility]);
    attributes.Add(AttributeName.Flexibility, flexibility);
    attributes.Add(AttributeName.ActionSpeed, actionSpeed);

    PrimaryAttribute sense = primaryAttribute.Clone();
    MiddleAttribute dexterity = new(exp.Clone(), [flexibility, sense]);
    attributes.Add(AttributeName.Sense, sense);
    attributes.Add(AttributeName.Dexterity, dexterity);

    return new PhysicalAttributes(attributes);
  }

  public MentalAttributes BuildMentalAttrs(ICascadeUpgrade mentalAbilityExp)
  {
    Dictionary<AttributeName, IGameAttribute> attributes = [];

    Experience exp = new(new ExpTable(MENTAL_ATTRIBUTE_COEFFICIENT));
    PrimaryAttribute attribute = new(exp, mentalAbilityExp);

    attributes.Add(AttributeName.Resilience, attribute.Clone());
    attributes.Add(AttributeName.Adaptability, attribute.Clone());
    attributes.Add(AttributeName.Weighting, attribute.Clone());
    attributes.Add(AttributeName.Creativity, attribute.Clone());

    return new MentalAttributes(attributes);
  }

  public StatusManager BuildStatusManager()
  {
    Dictionary<StatusName, IStatus> status = [];

    status.Add(StatusName.Stamina, new StaminaPoints());
    status.Add(StatusName.Health, new HitPoints());
    status.Add(StatusName.Aura, new AuraPoints());

    return new StatusManager(status);
  }

  public PhysicalSkills BuildPhysSkills(
    StatusManager status,
    ICascadeUpgrade skillsExp,
    ICascadeUpgrade physAbilityExp,
    Dictionary<AttributeName, IGameAttribute> physAttrs)
  {
    Dictionary<SkillName, ISkill> skills = [];

    Experience exp = new(new ExpTable(PHYSICAL_SKILLS_COEFFICIENT));
    PhysicalSkills physicalSkills = new(exp, skillsExp, physAbilityExp);

    var con = physAttrs.GetValueOrDefault(AttributeName.Constitution) ??
      throw new Exception("Attribute not found!");

    IStatus health = status.Get(StatusName.Health);
    StatusSkill vitSkill = new(health, exp.Clone(), con, physicalSkills);
    skills.Add(SkillName.Vitality, vitSkill);

    IStatus stamina = status.Get(StatusName.Stamina);
    StatusSkill resSkill = new(stamina, exp.Clone(), con, physicalSkills);
    skills.Add(SkillName.Resistance, resSkill);

    PersonSkill conSkill = new(exp.Clone(), con, physicalSkills);
    skills.Add(SkillName.Breath, conSkill.Clone());
    skills.Add(SkillName.Heal, conSkill.Clone());

    var def = physAttrs.GetValueOrDefault(AttributeName.Defense) ??
      throw new Exception("Attribute not found!");

    PersonSkill defSkill = new(exp.Clone(), def, physicalSkills);
    skills.Add(SkillName.Defense, defSkill.Clone());

    var str = physAttrs.GetValueOrDefault(AttributeName.Strength) ??
      throw new Exception("Attribute not found!");

    PersonSkill strSkill = new(exp.Clone(), str, physicalSkills);
    skills.Add(SkillName.Climb, strSkill.Clone());
    skills.Add(SkillName.Push, strSkill.Clone());
    skills.Add(SkillName.Grab, strSkill.Clone());
    skills.Add(SkillName.CarryCapacity, strSkill.Clone());

    var vel = physAttrs.GetValueOrDefault(AttributeName.Velocity) ??
      throw new Exception("Attribute not found!");

    PersonSkill velSkill = new(exp.Clone(), vel, physicalSkills);
    skills.Add(SkillName.Run, velSkill.Clone());
    skills.Add(SkillName.Swim, velSkill.Clone());
    skills.Add(SkillName.Jump, velSkill.Clone());

    var agi = physAttrs.GetValueOrDefault(AttributeName.Agility) ??
      throw new Exception("Attribute not found!");

    PersonSkill agiSkill = new(exp.Clone(), agi, physicalSkills);
    skills.Add(SkillName.Dodge, agiSkill.Clone());
    skills.Add(SkillName.Accelerate, agiSkill.Clone());
    skills.Add(SkillName.Brake, agiSkill.Clone());

    var ats = physAttrs.GetValueOrDefault(AttributeName.ActionSpeed) ??
      throw new Exception("Attribute not found!");

    PersonSkill atsSkill = new(exp.Clone(), ats, physicalSkills);
    skills.Add(SkillName.ActionSpeed, atsSkill.Clone());
    skills.Add(SkillName.Feint, atsSkill.Clone());

    var flx = physAttrs.GetValueOrDefault(AttributeName.Flexibility) ??
      throw new Exception("Attribute not found!");

    PersonSkill flxSkill = new(exp.Clone(), flx, physicalSkills);
    skills.Add(SkillName.Acrobatics, flxSkill.Clone());
    skills.Add(SkillName.Sneak, flxSkill.Clone());

    var dex = physAttrs.GetValueOrDefault(AttributeName.Dexterity) ??
      throw new Exception("Attribute not found!");

    PersonSkill dexSkill = new(exp.Clone(), dex, physicalSkills);
    skills.Add(SkillName.Reflex, dexSkill.Clone());
    skills.Add(SkillName.Accuracy, dexSkill.Clone());
    skills.Add(SkillName.Stealth, dexSkill.Clone());
    skills.Add(SkillName.SleightOfHand, dexSkill.Clone());

    var sen = physAttrs.GetValueOrDefault(AttributeName.Sense) ??
      throw new Exception("Attribute not found!");

    PersonSkill senSkill = new(exp.Clone(), sen, physicalSkills);
    skills.Add(SkillName.Vision, senSkill.Clone());
    skills.Add(SkillName.Hearing, senSkill.Clone());
    skills.Add(SkillName.Smell, senSkill.Clone());
    skills.Add(SkillName.Tact, senSkill.Clone());
    skills.Add(SkillName.Taste, senSkill.Clone());
    skills.Add(SkillName.Balance, senSkill.Clone());

    physicalSkills.Init(skills);
    return physicalSkills;
  }

  public MentalSkills BuildMentalSkills(
    ICascadeUpgrade skillsExp,
    ICascadeUpgrade mentalAbilityExp,
    Dictionary<AttributeName, IGameAttribute> mentalsAttrs)
  {
    Dictionary<SkillName, ISkill> skills = [];

    Experience exp = new(new ExpTable(MENTAL_SKILLS_COEFFICIENT));
    MentalSkills mentalSkills = new(exp, skillsExp, mentalAbilityExp);

    // TODO: resolve and finish this
    // var res = mentalsAttrs.GetValueOrDefault(AttributeName.Resilience) ??
    //   throw new Exception("Attribute not found!");

    // PersonSkill skill = new(exp.Clone(), mentalAttributeExp, mentalSkills);
    // skills.Add(SkillName., skill.Clone());

    return mentalSkills;
  }

  public Hatsu BuildHatsu(ICascadeUpgrade abilityExp)
  {
    Dictionary<NenCategoryName, NenCategory> categories = [];

    Experience exp = new(new ExpTable(SPIRITUAL_PRINCIPLE_COEFFICIENT));
    Hatsu hatsu = new(exp, abilityExp);

    NenCategory category = new(exp.Clone(), hatsu);
    foreach (NenCategoryName name in Enum.GetValues(typeof(NenCategoryName)))
    {
      categories.Add(name, category.Clone());
    }

    hatsu.Init(categories);
    return hatsu;
  }

  public SpiritualPrinciples BuildSpiritPrinciples(
    IStatus aura,
    ICascadeUpgrade spiritAbilityExp,
    Hatsu hatsu)
  {
    Dictionary<NenPrincipleName, NenPrinciple> principles = [];

    Experience exp = new(new ExpTable(SPIRITUAL_PRINCIPLE_COEFFICIENT));
    NenPrinciple principle = new(exp, spiritAbilityExp);

    foreach (NenPrincipleName name in Enum.GetValues(typeof(NenPrincipleName)))
    {
      if (name == NenPrincipleName.Hatsu) continue;
      // TODO: refactor this removing Mop of NenPrincipleName
      if (name == NenPrincipleName.Mop)
      {
        principles.Add(name, new NenStatus(aura, exp.Clone(), spiritAbilityExp));
        continue;
      }
      principles.Add(name, principle.Clone());
    }
    return new SpiritualPrinciples(principles, hatsu);
  }
}