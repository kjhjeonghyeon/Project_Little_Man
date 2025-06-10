

using UnrealBuildTool;
using System.Collections.Generic;

public class Project_Little_ManEditorTarget : TargetRules
{
	public Project_Little_ManEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Project_Little_Man" } );
	}
}
