using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A `Fund` is a way of tracking the intent of `Donation`.
/// 
/// All `Organization`s have a default `Fund` (usually named "General"), and creating additional `Fund`s allows donors to allocate their gift to a particular cause/effort.
/// 
/// You can query for the default `Fund` using the `default` param:
/// ```
/// GET https://api.planningcenteronline.com/giving/v2/funds?where[default]=true
/// ```
/// 
/// </summary>
public record Fund
{
  /// <summary>
  /// The unique identifier for a fund.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The date and time at which a fund was created. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a fund was last updated. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Required. The name for a fund. Must be unique within the associated organization.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// If an organization's general ledger software tracks funds by code, this attribute can be used to store the fund's code for reference.
  /// </summary>
  public string? LedgerCode { get; init; }

  /// <summary>
  /// A short description that describes how the money given to the fund will be used. 255 characters maximum.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// Required. Controls how a fund is visible on Church Center. `everywhere` will allow anyone to donate to the fund on Church Center. `admin_only` will hide the fund on Church Center, allowing only permitted Giving Users to designate donations to it. `nowhere` will prevent donations from being designated to the fund altogether, while still displaying fund data in historical reports. `hidden` will hide the fund from the list of funds in the default Church Center donation form, but allow donors to give to it via direct link, or through Text-to-Give.
  /// 
  /// Possible values: `everywhere`, `admin_only`, `nowhere`, or `hidden`
  /// </summary>
  public string? Visibility { get; init; }

  /// <summary>
  /// This attribute is set to `true` if a fund is the associated organization's default fund, or `false` if it isn't. More information on default funds can be found in our product documentation: https://pcogiving.zendesk.com/hc/en-us/articles/205197070-Funds
  /// </summary>
  public bool? Default { get; init; }

  /// <summary>
  /// The hex color code that is used to help differentiate the fund from others in Giving, as determined by `color_identifier`.
  /// </summary>
  public string? Color { get; init; }

  /// <summary>
  /// Boolean that tells if you if the fund can be deleted or not. Read more in our product documentation: https://pcogiving.zendesk.com/hc/en-us/articles/205197070-Managing-Funds#DeleteaFund
  /// </summary>
  public bool? Deletable { get; init; }

}
