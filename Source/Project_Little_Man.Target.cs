

using UnrealBuildTool;
using System.Collections.Generic;

public class Project_Little_ManTarget : TargetRules
{
	public Project_Little_ManTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Project_Little_Man" } );
	}
}
