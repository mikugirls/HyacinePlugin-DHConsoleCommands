using HyacineCore.Server.Enums.Avatar;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HyacinePlugin.DHConsoleCommands.Data;

public static class PluginConstants
{
    public static Dictionary<RelicTypeEnum, Dictionary<AvatarPropertyTypeEnum, int>> RelicMainAffix = new();
    public static Dictionary<AvatarPropertyTypeEnum, int> RelicSubAffix = new();
};