Ember.Handlebars.registerBoundHelper("fromDate", function (theDate) {
    var today = moment();
    var target = moment(theDate);
    return target.from(today);
});
