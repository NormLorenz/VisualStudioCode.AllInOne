app.IndexController = Ember.ArrayController.extend({
    renderedOn: function () {
        return new Date();
    }.property(),

    actions: {
        clickMe: function () {
            alert("I have been clicked");
        }
    }
});
