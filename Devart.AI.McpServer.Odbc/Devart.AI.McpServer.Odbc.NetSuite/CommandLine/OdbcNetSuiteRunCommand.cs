// --------------------------------------------------------------------------
// <copyright file="OdbcNetSuiteRunCommand.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Devart.AI.McpServer.Odbc.CommandLine;
using Devart.AI.McpServer.Odbc.NetSuite.Properties;

namespace Devart.AI.McpServer.Odbc.NetSuite.CommandLine
{
  internal sealed class OdbcNetSuiteRunCommand : OdbcRunCommand
  {
    protected override void RegisterTools(IMcpServerBuilder serverBuilder, McpConfiguration configuration)
      => serverBuilder.WithTools(OdbcNetSuiteTools.CreateTools(configuration));

    protected override string ProductFullName => ProductInfo.ProductFullName;

    protected override McpAppSettings CreateAppSettings() => new OdbcNetSuiteAppSettings();
  }
}