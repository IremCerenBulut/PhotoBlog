// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

dayjs.extend(window.dayjs_plugin_relativeTime)

/* 1. data-post-time attributelarını içeren tüm elemenetleri gez
 * 2. data-post-time attribute içinde yer alan değeri eline al
 * 3. daysjs().to(daysjs('')) metodu içine sok
 * 4. çıktısını, elimize 1. adımda aldığımız elementin metnine koy
 */
 
$("[data-post-time]").each(function () {
    let isoTime = $(this).data("post-time");
    let relativeTime = dayjs().to(dayjs(isoTime));
    $(this).text(relativeTime);
});