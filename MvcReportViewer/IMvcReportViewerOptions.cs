﻿using System.Web;

namespace MvcReportViewer
{
    public interface IMvcReportViewerOptions : IHtmlString
    {
        /// <summary>
        /// Sets the path to the report on the server.
        /// </summary>
        /// <param name="reportPath">The path to the report on the server.</param>
        /// <returns>An instance of MvcViewerOptions class.</returns>
        IMvcReportViewerOptions ReportPath(string reportPath);

        /// <summary>
        /// Sets the URL for the report server.
        /// </summary>
        /// <param name="reportServerUrl">The URL for the report server.</param>
        /// <returns>An instance of MvcViewerOptions class.</returns>
        IMvcReportViewerOptions ReportServerUrl(string reportServerUrl);

        /// <summary>
        /// Sets the report server username.
        /// </summary>
        /// <param name="username">The report server username.</param>
        /// <returns>An instance of MvcViewerOptions class.</returns>
        IMvcReportViewerOptions Username(string username);

        /// <summary>
        /// Sets the report server password.
        /// </summary>
        /// <param name="password">The report server password.</param>
        /// <returns>An instance of MvcViewerOptions class.</returns>
        IMvcReportViewerOptions Password(string password);

        /// <summary>
        /// Sets the report parameter properties for the report.
        /// </summary>
        /// <param name="reportParameters">The report parameter properties for the report.</param>
        /// <returns>An instance of MvcViewerOptions class.</returns>
        IMvcReportViewerOptions ReportParameters(object reportParameters);

        /// <summary>
        /// Sets the value that indicates wether parameter prompts are dispalyed.
        /// </summary>
        /// <param name="showParameterPrompts">The value that indicates wether parameter prompts are dispalyed.</param>
        /// <returns>An instance of MvcViewerOptions class.</returns>
        IMvcReportViewerOptions ShowParameterPrompts(bool showParameterPrompts);

        /// <summary>
        /// Sets an object that contains the HTML attributes to set for the element.
        /// </summary>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <returns>An instance of MvcViewerOptions class.</returns>
        IMvcReportViewerOptions Attributes(object htmlAttributes);
    }
}
