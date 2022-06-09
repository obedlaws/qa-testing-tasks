

pm.test("Status code should be 403", ()=>{
    pm.response.to.have.status(403);
})

pm.test("Should include warning on duplicate content", ()=>{
    const response = pm.response.json();
    const warning = response.detail;
    pm.expect(pm.response.text()).to.include(warning)
})

pm.test("Title should say 'Forbidden'", ()=>{
    const response = pm.response.json();
    const title = response.title;
    pm.expect(title).to.eql('Forbidden');
})

