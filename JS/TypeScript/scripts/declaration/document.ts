/// <reference path="jquery.d.ts" />

declare var document;
declare var $;

document.title = "New title";

$("#log").html(document.title);