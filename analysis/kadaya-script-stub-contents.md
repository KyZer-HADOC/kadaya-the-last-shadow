# Recovered Kadaya gameplay script-stub contents

Read-only inspection of small C# files from the recovered IL2CPP Android build. No gameplay files were edited.
The 1.77 GiB recovered project is not uploaded to the repository.


## PlayerDash.cs
File: Assets/Scripts/Assembly-CSharp/PlayerDash.cs (2642 bytes)
SOURCE START
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END

## SkillTree.cs
File: Assets/Scripts/Assembly-CSharp/SkillTree.cs (2641 bytes)
SOURCE START
using UnityEngine;

public class SkillTree : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END

## SkillButton.cs
File: Assets/Scripts/Assembly-CSharp/SkillButton.cs (2643 bytes)
SOURCE START
using UnityEngine;

public class SkillButton : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END

## HideObj.cs
File: Assets/Scripts/Assembly-CSharp/HideObj.cs (2639 bytes)
SOURCE START
using UnityEngine;

public class HideObj : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END

## DisguiseManager.cs
File: Assets/Scripts/Assembly-CSharp/DisguiseManager.cs (2647 bytes)
SOURCE START
using UnityEngine;

public class DisguiseManager : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END

## StoryCanvas.cs
File: Assets/Scripts/Assembly-CSharp/StoryCanvas.cs (2643 bytes)
SOURCE START
using UnityEngine;

public class StoryCanvas : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END

## CotTruyenLeader.cs
File: Assets/Scripts/Assembly-CSharp/CotTruyenLeader.cs (2647 bytes)
SOURCE START
using UnityEngine;

public class CotTruyenLeader : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END

## ShopPanel.cs
File: Assets/Scripts/Assembly-CSharp/ShopPanel.cs (2641 bytes)
SOURCE START
using UnityEngine;

public class ShopPanel : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END

## LevelLeader.cs
File: Assets/Scripts/Assembly-CSharp/LevelLeader.cs (2643 bytes)
SOURCE START
using UnityEngine;

public class LevelLeader : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END

## HUDText.cs
File: Assets/Scripts/Assembly-CSharp/HUDText.cs (2639 bytes)
SOURCE START
using UnityEngine;

public class HUDText : MonoBehaviour
{
	/*
	Dummy class. This could have happened for several reasons:

	1. No dll files were provided to AssetRipper.

		Unity asset bundles and serialized files do not contain script information to decompile.
			* For Mono games, that information is contained in .NET dll files.
			* For Il2Cpp games, that information is contained in compiled C++ assemblies and the global metadata.
			
		AssetRipper usually expects games to conform to a normal file structure for Unity games of that platform.
		A unexpected file structure could cause AssetRipper to not find the required files.

	2. Incorrect dll files were provided to AssetRipper.

		Any of the following could cause this:
			* Il2CppInterop assemblies
			* Deobfuscated assemblies
			* Older assemblies (compared to when the bundle was built)
			* Newer assemblies (compared to when the bundle was built)

		Note: Although assembly publicizing is bad, it alone cannot cause empty scripts. See: https://github.com/AssetRipper/AssetRipper/issues/653

	3. Assembly Reconstruction has not been implemented.

		Asset bundles contain a small amount of information about the script content.
		This information can be used to recover the serializable fields of a script.

		See: https://github.com/AssetRipper/AssetRipper/issues/655

	4. This script is unnecessary.

		If this script has no asset or script references, it can be deleted.
		Be sure to resolve any compile errors before deleting because they can hide references.

	5. Script Content Level 0

		AssetRipper was set to not load any script information.

	6. Cpp2IL failed to decompile Il2Cpp data

		If this happened, there will be errors in the AssetRipper.log indicating that it happened.
		This is an upstream problem, and the AssetRipper developer has very little control over it.
		Please post a GitHub issue at: https://github.com/SamboyCoding/Cpp2IL/issues

	7. An incorrect path was provided to AssetRipper.

		This is characterized by "Mixed game structure has been found at" in the AssetRipper.log file.
		AssetRipper expects games to conform to a normal file structure for Unity games of that platform.
		An unexpected file structure could cause AssetRipper to not find the required files for script decompilation.
		Generally, AssetRipper expects users to provide the root folder of the game. For example:
			* Windows: the folder containing the game's .exe file
			* Mac: the .app file/folder
			* Linux: the folder containing the game's executable file
			* Android: the apk file
			* iOS: the ipa file
			* Switch: the folder containing exefs and romfs

	*/
}
SOURCE END
