// --------------------------------------------------------------------------
// <copyright file="OdbcNetSuiteTools.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using ModelContextProtocol.Server;
using Devart.AI.McpServer.Odbc.NetSuite.Tools;

namespace Devart.AI.McpServer.Odbc.NetSuite
{
  internal static class OdbcNetSuiteTools
  {
    public static List<McpServerTool> CreateTools(McpConfiguration configuration)
      => OdbcTools.CreateBuilder(configuration)
        .Add(new OdbcNetSuitePrimaryKeysTool(configuration))
        .Add(new OdbcNetSuiteForeignKeysTool(configuration))
        .Build();
  }
}
