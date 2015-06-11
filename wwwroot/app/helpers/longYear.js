Ember.Handlebars.registerBoundHelper("longYear", function (theDate) {
    return moment(theDate).format('YYYY');
});
