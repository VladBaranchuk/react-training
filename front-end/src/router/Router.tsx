import { FC } from 'react'
import { BrowserRouter as Router, Routes as Switch, Route } from 'react-router-dom'
import { routes } from './routes'
const Routes: FC = () => {

    return (
        <Router>
            <Switch>
                {routes.map(route => {
                    return (
                        <Route
                            path={route.path}
                            key={`route ${route.path}`}
                            element={<route.element/>}
                        />
                    )
                })}
            </Switch>
        </Router>
    )
}

export default Routes 