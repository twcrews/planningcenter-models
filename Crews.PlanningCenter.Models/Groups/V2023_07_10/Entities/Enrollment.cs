using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// Details on how and when members can join a `Group`.
/// 
/// </summary>
public record Enrollment
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Whether or not enrollment has been closed automatically due to set limits
  /// 
  /// </summary>
  public bool? AutoClosed { get; init; }

  /// <summary>
  /// Brief description as to which limit automatically closed enrollment
  /// 
  /// </summary>
  public string? AutoClosedReason { get; init; }

  /// <summary>
  /// Date when enrollment should automatically close
  /// 
  /// </summary>
  public string? DateLimit { get; init; }

  /// <summary>
  /// Whether or not the `date_limit` has been reached
  /// 
  /// </summary>
  public bool? DateLimitReached { get; init; }

  /// <summary>
  /// Total number of members allowed before enrollment should automatically close
  /// 
  /// </summary>
  public int? MemberLimit { get; init; }

  /// <summary>
  /// Whether or not the `member_limit` has been reached
  /// 
  /// </summary>
  public bool? MemberLimitReached { get; init; }

  /// <summary>
  /// Current enrollment status. Possible values:
  /// * `open` - strategy is not `closed` and no limits have been reached
  /// * `closed` - strategy is `closed` _or_ limits have been reached
  /// * `full` - member limit has been reached
  /// * `private` - group is unlisted
  /// 
  /// </summary>
  public string? Status { get; init; }

  /// <summary>
  /// Sign up strategy. Possible values: `request_to_join`, `open_signup`, or `closed`
  /// 
  /// </summary>
  public string? Strategy { get; init; }

}
