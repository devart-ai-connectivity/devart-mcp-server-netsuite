// --------------------------------------------------------------------------
// <copyright file="OdbcNetSuiteAppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.Odbc.NetSuite
{
  internal sealed class OdbcNetSuiteAppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "NetSuite";

    public override bool OnPremise => false;
  }
}
