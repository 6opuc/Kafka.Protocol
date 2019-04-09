﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Kafka.Protocol.Generator.Definitions.Messages;
using Newtonsoft.Json;
using Octokit;
using ProductHeaderValue = Octokit.ProductHeaderValue;

namespace Kafka.Protocol.Generator
{
    public class KafkaGithubRepositoryClient
    {
        private readonly GitHubClient _client = new GitHubClient(
                    new ProductHeaderValue("Kafka.Protocol"));

        internal async Task<IEnumerable<Message>> GetMessages()
        {
            var files = await GetMessageFiles();

            var fileClient = new HttpClient();

            var messagesContent = await Task.WhenAll(files
                .Select(async repositoryContent =>
                    await
                        (await fileClient
                            .GetAsync(repositoryContent.DownloadUrl))
                        .Content
                        .ReadAsStringAsync()).ToArray());

            return messagesContent
                .Select(
                    JsonConvert.DeserializeObject<Message>);
        }

        public async Task GetMessagesAndWriteToPath(string path)
        {
            var files = await GetMessageFiles();

            await Task.WhenAll(files
                .Select(async repositoryContent =>
                        await new WebClient()
                            .DownloadFileTaskAsync(
                                repositoryContent.DownloadUrl,
                                $"{path}\\{repositoryContent.Name}")));
        }
        
        private async Task<IEnumerable<RepositoryContent>> GetMessageFiles()
        {
            var content = await _client
                .Repository
                .Content
                .GetAllContents(
                    "apache",
                    "kafka",
                    "clients/src/main/resources/common/message");

            var messages = content
                .Where(repositoryContent =>
                    repositoryContent
                        .Name
                        .EndsWith(".json"));

            return messages;
        }
    }
}