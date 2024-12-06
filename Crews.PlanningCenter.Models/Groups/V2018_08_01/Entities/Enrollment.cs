using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// Details on how and when members can join a <c>Group</c>.
/// </summary>
[JsonApiName("enrollment")]
public record Enrollment
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Whether or not enrollment has been closed automatically due to set limits
  /// </summary>
  [JsonApiName("auto_closed")]
  public bool? AutoClosed { get; init; }

  /// <summary>
  /// Brief description as to which limit automatically closed enrollment
  /// </summary>
  [JsonApiName("auto_closed_reason")]
  public string? AutoClosedReason { get; init; }

  /// <summary>
  /// Date when enrollment should automatically close
  /// </summary>
  [JsonApiName("date_limit")]
  public string? DateLimit { get; init; }

  /// <summary>
  /// Whether or not the <c>date_limit</c> has been reached
  /// </summary>
  [JsonApiName("date_limit_reached")]
  public bool? DateLimitReached { get; init; }

  /// <summary>
  /// Total number of members allowed before enrollment should automatically close
  /// </summary>
  [JsonApiName("member_limit")]
  public int? MemberLimit { get; init; }

  /// <summary>
  /// Whether or not the <c>member_limit</c> has been reached
  /// </summary>
  [JsonApiName("member_limit_reached")]
  public bool? MemberLimitReached { get; init; }

  /// <summary>
  /// Current enrollment status. Possible values:
  /// * <c>open</c> - strategy is not <c>closed</c> and no limits have been reached
  /// * <c>closed</c> - strategy is <c>closed</c> _or_ limits have been reached
  /// * <c>full</c> - member limit has been reached
  /// * <c>private</c> - group is unlisted
  /// </summary>
  [JsonApiName("status")]
  public string? Status { get; init; }

  /// <summary>
  /// Sign up strategy. Possible values: <c>request_to_join</c>, <c>open_signup</c>, or <c>closed</c>
  /// </summary>
  [JsonApiName("strategy")]
  public string? Strategy { get; init; }

}
