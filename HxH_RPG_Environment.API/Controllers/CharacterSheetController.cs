using HxH_RPG_Environment.API.Dtos;
using HxH_RPG_Environment.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace HxH_RPG_Environment.API.Controllers;

[ApiController]
[Route("charactersheet")]
public class CharacterSheetController() : ControllerBase
{
    [HttpPost]
    public IActionResult PostCharacterSheet([FromBody] InputCharacterSheetDto dto)
    {
        // Console.WriteLine(dto.Abilities.PhysicAbility.Exp.Points);
        // Console.WriteLine(dto.Abilities.PhysicAbility.Exp.Level);
        // Console.WriteLine(dto.CharacterAttrs.SpiritAttributes.Length);
        // Console.WriteLine(dto.CharacterAttrs.MentalAttributes.Length);
        // Console.WriteLine(dto.CharacterAttrs.PhysicAttributes.Length);

        //     Profile profile,
        // AbilitiesManager abilities,
        // CharacterAttributes attributes,
        // CharacterSkills skills,
        // PrinciplesManager principles,
        // StatusManager status)


        return Ok(dto.Abilities.Get(AbilityName.PHYSICALS).Exp.Points.ToString());
    }
}
