using HxH_RPG_Environment.Domain.Experiences;
using HxH_RPG_Environment.Domain.Skills;
using HxH_RPG_Environment.Domain.Enums;

namespace HxH_RPG_Environment.Domain.Physicals;

public class PhysicalSkills : ICascadeUpgrade, IEndCascadeUpgrade
{
  private const double COEFFICIENT = 1.0;
  private readonly Dictionary<SkillName, ISkill> skills = [];
  public Experience Exp { get; private init; }
  public ICascadeUpgrade PhysAbilityExp { get; private init; }

  public PhysicalSkills(
    Experience physSkillsExp,
    Dictionary<AttributeName, ICascadeUpgrade> physAttrExps,
    ICascadeUpgrade physAbilityExp)
  {
    Exp = physSkillsExp;
    PhysAbilityExp = physAbilityExp;

    Experience skillExp = new(new ExpTable(COEFFICIENT));

    var con = physAttrExps.GetValueOrDefault(AttributeName.Constitution) ??
      throw new Exception("AttributeName not found!");

    PersonSkill conSkill = new(skillExp.Clone(), con, this);
    skills.Add(SkillName.Vitality, conSkill.Clone());
    skills.Add(SkillName.Resistance, conSkill.Clone());
    skills.Add(SkillName.Breath, conSkill.Clone());
    skills.Add(SkillName.Heal, conSkill.Clone());

    var def = physAttrExps.GetValueOrDefault(AttributeName.Defense) ??
      throw new Exception("AttributeName not found!");

    PersonSkill defSkill = new(skillExp.Clone(), def, this);
    skills.Add(SkillName.Defense, defSkill.Clone());

    var str = physAttrExps.GetValueOrDefault(AttributeName.Strength) ??
      throw new Exception("AttributeName not found!");

    PersonSkill strSkill = new(skillExp.Clone(), str, this);
    skills.Add(SkillName.Climb, strSkill.Clone());
    skills.Add(SkillName.Push, strSkill.Clone());
    skills.Add(SkillName.Pull, strSkill.Clone());
    skills.Add(SkillName.Grab, strSkill.Clone());

    var vel = physAttrExps.GetValueOrDefault(AttributeName.Velocity) ??
      throw new Exception("AttributeName not found!");

    PersonSkill velSkill = new(skillExp.Clone(), vel, this);
    skills.Add(SkillName.Run, velSkill.Clone());
    skills.Add(SkillName.Swim, velSkill.Clone());
    skills.Add(SkillName.Jump, velSkill.Clone());

    var agi = physAttrExps.GetValueOrDefault(AttributeName.Agility) ??
      throw new Exception("AttributeName not found!");

    PersonSkill agiSkill = new(skillExp.Clone(), agi, this);
    skills.Add(SkillName.Dodge, agiSkill.Clone());
    skills.Add(SkillName.Accelerate, agiSkill.Clone());
    skills.Add(SkillName.Brake, agiSkill.Clone());

    var ats = physAttrExps.GetValueOrDefault(AttributeName.ActionSpeed) ??
      throw new Exception("AttributeName not found!");

    PersonSkill atsSkill = new(skillExp.Clone(), ats, this);
    skills.Add(SkillName.ActionSpeed, atsSkill.Clone());
    skills.Add(SkillName.Feint, atsSkill.Clone());

    var flx = physAttrExps.GetValueOrDefault(AttributeName.Flexibility) ??
      throw new Exception("AttributeName not found!");

    PersonSkill flxSkill = new(skillExp.Clone(), flx, this);
    skills.Add(SkillName.Acrobatics, flxSkill.Clone());
    skills.Add(SkillName.Sneak, flxSkill.Clone());

    var dex = physAttrExps.GetValueOrDefault(AttributeName.Dexterity) ??
      throw new Exception("AttributeName not found!");

    PersonSkill dexSkill = new(skillExp.Clone(), dex, this);
    skills.Add(SkillName.Reflex, dexSkill.Clone());
    skills.Add(SkillName.Accuracy, dexSkill.Clone());
    skills.Add(SkillName.Stealth, dexSkill.Clone());
    skills.Add(SkillName.SleightOfHand, dexSkill.Clone());

    var sen = physAttrExps.GetValueOrDefault(AttributeName.Sense) ??
      throw new Exception("AttributeName not found!");

    PersonSkill senSkill = new(skillExp.Clone(), sen, this);
    skills.Add(SkillName.Vision, senSkill.Clone());
    skills.Add(SkillName.Hearing, senSkill.Clone());
    skills.Add(SkillName.Smell, senSkill.Clone());
    skills.Add(SkillName.Tact, senSkill.Clone());
    skills.Add(SkillName.Taste, senSkill.Clone());
    skills.Add(SkillName.Balance, senSkill.Clone());
  }

  // TODO: refactor this exception
  public ISkill Get(SkillName name)
  {
    return skills.GetValueOrDefault(name) ??
      throw new Exception("Skill not found!");
  }

  public int GetLvlOf(SkillName name)
  {
    return Get(name).GetLvl();
  }

  public void CascadeUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
    PhysAbilityExp.CascadeUpgrade(exp);
  }

  public void TriggerEndUpgrade(int exp)
  {
    Exp.IncreasePoints(exp);
  }
}