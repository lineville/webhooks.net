namespace JamieMagee.Octokit.Webhooks.Events.Milestone
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    [WebhookActionType(MilestoneActionValue.Closed)]
    public sealed record MilestoneClosedEvent : MilestoneEvent
    {
        [JsonPropertyName("action")]
        public override string Action => MilestoneAction.Closed;
    }
}