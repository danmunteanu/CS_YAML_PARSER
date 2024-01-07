using C__Yaml_Parser;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Markdig;
using Markdig.Extensions.Yaml;
using Markdig.Syntax;

namespace C__Yaml_Parser
{
    public static class MarkdownExtensions
    {
        private static readonly IDeserializer YamlDeserializer =
            new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .IgnoreUnmatchedProperties()
                .Build();

        //  Pipeline
        private static readonly MarkdownPipeline Pipeline =
            new MarkdownPipelineBuilder()
                .UseYamlFrontMatter()
                .Build();

        public static T GetFrontMatter<T>(this string markdown)
        {
            var document = Markdown.Parse(markdown, Pipeline);
            var block = document
                .Descendants<YamlFrontMatterBlock>()
                .FirstOrDefault();

            if (block == null)
                return default;

            var yaml = block.Lines.ToString();

            return YamlDeserializer.Deserialize<T>(yaml);
        }
    }
}
