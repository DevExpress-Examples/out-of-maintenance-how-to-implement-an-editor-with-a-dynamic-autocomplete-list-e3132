<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621151/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3132)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to implement an editor with a dynamic autocomplete list

<strong>Starting with version 19.2, LookUpEdit supports the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.LookUpEdit#autosuggest-mode">AutoSuggest Mode<a/>. When a user types in text, the editor fires the AutoSuggest event that runs a custom asynchronous task. This task performs a search against the given data set, and returns the ICollection object with records that match the entered text.</strong>

<strong>For earlier versions:</strong>

<p>This example demonstrates how to create a custom LookUpEdit class descendant that allows you to provide autocomplete items based on typed text. The items can be provided via the GetAutoCompleteList event.</p>

<br/>


