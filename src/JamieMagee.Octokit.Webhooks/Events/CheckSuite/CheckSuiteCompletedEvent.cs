namespace JamieMagee.Octokit.Webhooks.Events.CheckSuite
{
    using System.Text.Json.Serialization;

    [WebhookActionType(CheckSuiteActionValue.Completed)]
    public sealed record CheckSuiteCompletedEvent : CheckSuiteEvent
    {
        [JsonPropertyName("action")]
        public override string Action => CheckSuiteAction.Completed;
    }
}