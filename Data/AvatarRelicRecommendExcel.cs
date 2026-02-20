using HyacineCore.Server.Data;
using HyacineCore.Server.Enums.Avatar;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HyacinePlugin.DHConsoleCommands.Data;

[ResourceEntity("AvatarRelicRecommend.json")]
public class AvatarRelicRecommendExcel : ExcelResource
{
    public List<RelicRecommendProperty> PropertyList { get; set; } = [];
    public List<int> Set4IDList { get; set; } = [];

    [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
    public List<AvatarPropertyTypeEnum> SubAffixPropertyList { get; set; } = [];
    public List<int> Set2IDList { get; set; } = [];
    public int AvatarID { get; set; }

    public override int GetId()
    {
        return AvatarID;
    }

    public override void Loaded()
    {
        PluginGameData.AvatarRelicRecommendData[AvatarID] = this;
    }
}

public class RelicRecommendProperty
{
    [JsonConverter(typeof(StringEnumConverter))]
    public RelicTypeEnum RelicType { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public AvatarPropertyTypeEnum PropertyType { get; set; }
}